using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace TriviaUiTestII
{

    public struct CreateRoomRequest
    {
        public string name { get; set; }
        public uint max_players { get; set; }
        public uint question_count { get; set; }
        public uint time_to_answer { get; set; }
        public bool roomCreated { get; set; }
    }

 

    public partial class CreateRoomScreen : Form
    {

        public bool update = false;
        private Timer timer;
        public struct GetRoomStateResponse
        {
            public uint status { get; set; }
            public bool isActive { get; set; }
            public List<string> players { get; set; }
            public uint NumQuestions { get; set; }
            public uint timePerQuestion { get; set; }

        }
        public CreateRoomScreen()
        {
            InitializeComponent();

            PlayersCount.Text = "0";
            numberOfQuestions.Text = "0";
            timeToAnswer.Text = "0";
        }



        private void CreateRoomScreen_Load(object sender, EventArgs e)
        {

            PlayersCount.Text = "0";
            numberOfQuestions.Text = "0";
            timeToAnswer.Text = "0";


            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();

            create.Visible = false;
            fakeCreate.Visible = true;
        }



        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (update && this.Visible == true)
            {
                await Task.Run(() => getRoomState());
            }
        }


        private void checkInfo()
        {
            int questions = Convert.ToInt32(numberOfQuestions.Text);
            int time = Convert.ToInt32(timeToAnswer.Text);
            int players = NumberOfPlayers_Bar.Value;

            if (RoomName.Text.ToString().Length > 0 && players > 0 && time > 0 && questions > 0)
            {
                create.Visible = true;
                fakeCreate.Visible = false;
            }
            else
            {
                create.Visible = false;
                fakeCreate.Visible = true;
            }
        }


        private void createRoomSend(object sender, EventArgs e)
        {
            CreateRoomRequest req = new CreateRoomRequest
            {
                name = RoomName.Text.ToString(),
                max_players = (uint)NumberOfPlayers_Bar.Value,
                question_count = (uint)NumberOfQuestion_Bar.Value,
                time_to_answer = (uint)TimeToAnswer_Bar.Value,
                roomCreated = true
            };
            int code = 13;

            Arranger.client.SendRequest(code, req);


            StatusResponse response = Arranger.client.DeserializeResponse<StatusResponse>();
            if (response.status == 0)
            {
                MessageBox.Show("Room has been Created");
                SetControlsVisibility(this, "Create", false);
                SetControlsVisibility(this, "wait", true);

                update = true;
            }
            else
            {
                MessageBox.Show("There's been an error in creating room");
            }

        }
 

        private void NumberOfPlayers_Bar_Scroll(object sender, EventArgs e)
        {
            PlayersCount.Text = NumberOfPlayers_Bar.Value.ToString();
            checkInfo();
        }

        private void NumberOfQuestion_Bar_Scroll(object sender, EventArgs e)
        {
            numberOfQuestions.Text = NumberOfQuestion_Bar.Value.ToString();
            checkInfo();
        }

        private void TimeToAnswer_Bar_Scroll(object sender, EventArgs e)
        {
            timeToAnswer.Text = TimeToAnswer_Bar.Value.ToString();
            checkInfo();
        }


        private void Back_Click(object sender, EventArgs e)
        {

            if (this.StartBut.Visible == true)
            {
                SetControlsVisibility(this, "Create", false);
                SetControlsVisibility(this, "wait", false);
                update = false;

                Arranger.MenuScreen.Location = this.Location;
                Arranger.MenuScreen.Size = this.Size;

                Arranger.CreateRoomS.Visible = false;
                Arranger.MenuScreen.Visible = true;
                closeRoom();

            }
            else
            {
                Arranger.MenuScreen.Location = this.Location;
                Arranger.MenuScreen.Size = this.Size;

                Arranger.CreateRoomS.Visible = false;
                Arranger.MenuScreen.Visible = true;

            }
        }

        private void RoomName_TextChanged(object sender, EventArgs e)
        {
            checkInfo();
        }

        private void create_Click(object sender, EventArgs e)
        {
            createRoomSend(sender, e);
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

        private void StartBut_Click(object sender, EventArgs e)
        {
            int code = 20;
            Arranger.client.SendRequest(code, new { });
            StatusResponse response = Arranger.client.DeserializeResponse<StatusResponse>();
            if (response.status == 0)
            {
                MessageBox.Show("Game has Started");
                SetControlsVisibility(this, "wait", false);
            }
            else
            {
                MessageBox.Show("ERORR starting the game!:(");
            }
        }

        private void getRoomState()
        {
            int code = 22;
            if (StartBut.Visible == true)
            {
                Arranger.client.SendRequest(code, new { });
                GetRoomStateResponse response = Arranger.client.DeserializeResponse<GetRoomStateResponse>();

                if (response.isActive || response.status == 1)
                {
                    Invoke(new Action(() =>
                    {
                        SetControlsVisibility(this, "wait", false);
                        MessageBox.Show("Game has Started");
                    }));
                }
                else if (response.status == 0 && !response.isActive)
                {
                    Invoke(new Action(() =>
                    {
                        Num.Text = response.NumQuestions.ToString();
                        Time.Text = response.timePerQuestion.ToString();
                        UpdatePlayersList(response.players);
                    }));
                }
                else if (response.status == 2)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("Err");
                    }));
                }
            }
        }

        private void UpdatePlayersList(List<string> players)
        {
            if (wait.InvokeRequired)
            {
                wait.Invoke(new Action(() =>
                {
                    wait.Items.Clear();
                    foreach (var player in players)
                    {
                        wait.Items.Add(player);
                    }
                }));
            }
            else
            {
                wait.Items.Clear();
                foreach (var player in players)
                {
                    wait.Items.Add(player);
                }
            }
        }

        private void closeRoom()
        {
            int code = 19;
            Arranger.client.SendRequest(code, new { });
        }
    }
}




