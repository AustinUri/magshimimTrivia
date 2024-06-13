using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Timer = System.Windows.Forms.Timer;


namespace TriviaUiTestII
{
    public partial class triviaMenuScreen : Form
    {

        public bool update = false;
        private Timer timer; 
        public struct LogoutRequest
        {
            public string username { get; set; }
        }

        public struct roomData
        {
            public uint id { get; set; }
            public string name { get; set; }

            public int maxPlayers { get; set; }
            public int NumQuestions { get; set; }
            public int timePerQuestion { get; set; }
            public bool isActive { get; set; }
        };

        public struct JoinRoomRequest
        {
            public uint roomID { get; set; }
        };


        public struct GetRoomsResponse
        {
            public uint status { get; set; }
            public roomData[] rooms { get; set; }

        }

        public struct GetRoomStateResponse
        {
            public uint status { get; set; }
            public bool isActive { get;set; }
            public List<string> players { get; set; }
            public uint NumQuestions { get; set; }
            public uint timePerQuestion { get; set; }

        }


        public struct StatisticsData
        {
            public string userName { get; set; }
            public float avgAnswerTime { get; set; }
            public int correctAnswers { get; set; }
            public int totalAnswers { get; set; }
            public int numOfGames { get; set; }
            public float score { get; set; }

        };

        public struct StatisticResponse
        {
            public uint status { get; set; }
            public StatisticsData statistics { get; set; }

        }

        public struct highScores
        {
            public uint status { get; set; }
            public StatisticsData[] highScoress { get; set; }
        }



        public triviaMenuScreen()
        {
            InitializeComponent();
            this.Visible = false;
        }
        private void triviaMenuScreen_Load(object sender, EventArgs e)
        {
            welcome.Text = "Welcome " + Arranger.ClientName;

            SetControlsVisibility(this, "TriviaMenu", true);
            SetControlsVisibility(this, "backButton", false);

            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        private void CreateRoom_Click(object sender, EventArgs e)
        {
            Arranger.MenuScreen.Visible = false;



            Arranger.CreateRoomS.Location = this.Location;
            Arranger.CreateRoomS.Size = this.Size;
            Arranger.CreateRoomS.SetControlsVisibility(Arranger.CreateRoomS, "Create", true);
            Arranger.CreateRoomS.Visible = true;
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (update && this.Visible == true)
            {
                await Task.Run(() => UpdateRoomButtons());
            }
        }

        private void UpdateRoomButtons()
        {
            this.Invoke((MethodInvoker)delegate {
                RemoveControlsByTag(this, "FindRoomButtons");
            });

            updateRoom();

            this.Invoke((MethodInvoker)delegate {
                SetControlsVisibility(this, "FindRoomButtons", true);
            });
        }


        public void updateRoom()
        {
            if (this.Visible == true && this.Refresh.Visible == true)
            {
                Arranger.client.SendRequest(16, new { });
                GetRoomsResponse response = Arranger.client.DeserializeResponse<GetRoomsResponse>();

                int buttonYPosition = 122;
                int buttonHeight = 30;
                int spacing = 10;
                int totalRooms = 0;

                if (response.rooms == null)
                    totalRooms = 0;
                else
                    totalRooms = response.rooms.Length;

                for (int i = 0; i < totalRooms; i++)
                {
                    var room = response.rooms[i];
                    Button newButton = new Button();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Controls.Add(newButton);
                        newButton.Text = room.name;
                        newButton.Location = new Point(28, buttonYPosition);
                        newButton.BackColor = Color.White;
                        newButton.Size = new Size(200, buttonHeight);
                        newButton.Tag = "FindRoomButtons";
                        newButton.BringToFront();
                        newButton.Click += (s, e) => joinRoom(room.id);
                    });

                    buttonYPosition += buttonHeight + spacing;
                }

            }
            else
            {
            }
        }        
        private void joinRoom(uint roomID)
        {
            JoinRoomRequest req = new JoinRoomRequest
            {
                roomID = roomID
            };

            MessageBox.Show("Room ID: " + roomID);

            Arranger.client.SendRequest(12, req);
            StatusResponse response = Arranger.client.DeserializeResponse<StatusResponse>();

            if(response.status == 0)
            {
                Arranger.client.SendRequest(22, req);
                GetRoomStateResponse res = Arranger.client.DeserializeResponse<GetRoomStateResponse>();
                if (res.status == 0)
                {
                    this.Visible = false;
                    Arranger.MemberWaitingRoomS.Visible = true;
                    DeleteAllCreatedButtons();
                    Arranger.MemberWaitingRoomS.Time.Text = res.timePerQuestion.ToString();
                    Arranger.MemberWaitingRoomS.Num.Text = res.NumQuestions.ToString();
                    foreach (string item in res.players)
                    {
                        Arranger.MemberWaitingRoomS.listBox1.Items.Add(item);
                    }
                }
                else if(res.status == 1)
                {
                    MessageBox.Show("Game has Started");
                    //nothing more,no time to implement the game itslef
                }
                else
                {
                    MessageBox.Show("Room has benn closed");
                }
            }
            else
            {
                MessageBox.Show("There's been an error in creating room");
            }
        }


        private void FindRooms_Click(object sender, EventArgs e)
        {
            // Handle FindRooms Click event
            SetControlsVisibility(this, "TriviaMenu", false);

            SetControlsVisibility(this, "backButton", true);
            SetControlsVisibility(this, "FindRoom", true);

            update = true; // Set update flag to true
        }
    


        private void GetUserStatistics_Click(object sender, EventArgs e)
        {
            SetControlsVisibility(this, "TriviaMenu", false);
            SetControlsVisibility(this, "backButton", true);
            SetControlsVisibility(this, "Statistic", true);


            Arranger.client.SendRequest(15, new { });
            StatisticResponse response = Arranger.client.DeserializeResponse<StatisticResponse>();

            
            WelcomeStat.Text = "Personal " + response.statistics.userName + " Stats";
            totalAns.Text = "Total Answers: " + response.statistics.totalAnswers.ToString();
            avgAns.Text = "Average Answer Time: " + response.statistics.avgAnswerTime.ToString();
            correctAns.Text = "Correct Answers: " + response.statistics.correctAnswers.ToString();
            TotalGames.Text = "Total Games Played: " + response.statistics.numOfGames.ToString();
            Score.Text = "YOUR SCORE!: " + response.statistics.score.ToString();
            
        }


        private void Statistics_Click(object sender, EventArgs e)
        {
            SetControlsVisibility(this, "TriviaMenu", false);
            SetControlsVisibility(this, "backButton", true);


            Arranger.client.SendRequest(18, new { });
            highScores response = Arranger.client.DeserializeResponse<highScores>();
            int len = response.highScoress.Count();

            Label[] labels = { USER1, USER2, USER3, USER4, USER5 };
            for (int i = 0; i < len; i++)
            {

                labels[i].Text = "" + (i+1) + ".) " + response.highScoress[i].userName + " " + response.highScoress[i].score;
            }


            SetControlsVisibility(this, "highS", true);
        }


        private void RemoveControlsByTag(Control container, object tagToRemove)
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in container.Controls)
            {
                if (control.Tag != null && control.Tag.Equals(tagToRemove))
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                container.Controls.Remove(control);
                control.Dispose();
            }
        }

        public void SetControlsVisibility(Control parent, string tag, bool visibility)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == tag)
                {
                    control.Visible = visibility;
                }

                if (control.HasChildren)
                {
                    SetControlsVisibility(control, tag, visibility);
                }
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogoutRequest request = new LogoutRequest
            {
                username = Arranger.ClientName     
            };

            string yes = Arranger.ClientName;
            Arranger.client.SendRequest(17, request);
            StatusResponse response = Arranger.client.DeserializeResponse<StatusResponse>();

            if (response.status == 0)
            {
                Arranger.MenuScreen.Visible = false;

                Arranger.LoginScreen.Location = this.Location;
                Arranger.LoginScreen.Size = this.Size;
                Arranger.LoginScreen.Visible = true;

                Arranger.client.Start(); // we must start new handle, old client existed
            }
            else
            {
                MessageBox.Show("Theres been an error in registering");
            }


        }

        private void ExitOrLogOut_Click(object sender, EventArgs e)
        {
            LogOut_Click(this, e);
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SetControlsVisibility(this, "TriviaMenu", true);
            SetControlsVisibility(this, "backButton", false);
            SetControlsVisibility(this, "Statistic", false);
            SetControlsVisibility(this, "highS", false);
            SetControlsVisibility(this, "FindRoom", false);
            SetControlsVisibility(this, "FindRoomButtons", false);

            update = false;


        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RemoveControlsByTag(this, "FindRoomButtons");
            updateRoom();
        }


        // Method to delete all created buttons
        public void DeleteAllCreatedButtons()
        {
            // Collect all controls that match the tag "FindRoomButtons"
            var buttonsToRemove = this.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString() == "FindRoomButtons").ToList();

            // Remove each button from the controls collection
            foreach (var button in buttonsToRemove)
            {
                this.Controls.Remove(button);
                button.Dispose();
            }
        }

    }
}

