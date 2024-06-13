using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TriviaUiTestII
{
    public partial class MemberWaitingRoom : Form
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

        public MemberWaitingRoom()
        {
            InitializeComponent();
        }

        private void MemberWaitingRoom_Load(object sender, EventArgs e)
        {
            update = true;

            timer = new Timer();
            timer.Interval = 10000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (update && this.Visible)
            {
                await Task.Run(() => getRoomState());
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            int code = 21;
            Arranger.client.SendRequest(code, new { });

            Arranger.MenuScreen.Location = this.Location;
            Arranger.MenuScreen.Size = this.Size;

            Arranger.MemberWaitingRoomS.Visible = false;
            Arranger.MenuScreen.Visible = true;

            Arranger.MenuScreen.SetControlsVisibility(Arranger.MenuScreen, "FindRoom", false);
            Arranger.MenuScreen.SetControlsVisibility(Arranger.MenuScreen, "TriviaMenu", true);
        }

        private void SetControlsVisibility(Control parent, string tag, bool visibility)
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

        private void getRoomState()
        {
            int code = 22;
            if (this.Visible)
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
                        update = false;
                        MessageBox.Show("Admin Left The room");

                        Arranger.MenuScreen.Location = this.Location;
                        Arranger.MenuScreen.Size = this.Size;

                        Arranger.MemberWaitingRoomS.Visible = false;
                        Arranger.MenuScreen.Visible = true;

                        Arranger.MenuScreen.SetControlsVisibility(Arranger.MenuScreen, "TriviaMenu", true);
                        Arranger.MenuScreen.SetControlsVisibility(Arranger.MenuScreen, "backButton", false);
                    }));
                }
            }
        }

        private void UpdatePlayersList(List<string> players)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() =>
                {
                    listBox1.Items.Clear();
                    foreach (var player in players)
                    {
                        listBox1.Items.Add(player);
                    }
                }));
            }
            else
            {
                listBox1.Items.Clear();
                foreach (var player in players)
                {
                    listBox1.Items.Add(player);
                }
            }
        }
    }
}
