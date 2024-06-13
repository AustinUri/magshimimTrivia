using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TriviaUiTestII
{

    public struct StatusResponse
    {
        public uint status { get; set; }
    }


    public struct LoginRequest {
      public string username { get; set; }
      public string password { get; set; }
   }

   public struct SignupRequest {
      public string username { get; set; }
      public string password { get; set; }
      public string mail { get; set; }
   }

    public partial class LogInScreen : Form
    {
        public LogInScreen( )
        {
            InitializeComponent();
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {
            Arranger.client.Start();

            terms.Visible = false;
            login.Visible = true;
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

        private void LogInButtonClick(object sender, EventArgs e)
        {
            LoginRequest request = new LoginRequest
            {
               username = LogInUserName.Text,
               password = LogInPassword.Text,
            };

            Arranger.client.SendRequest(10, request);
            StatusResponse response = Arranger.client.DeserializeResponse<StatusResponse>();

            if (response.status == 0)
            {
                terms.Visible = true;
                Arranger.ClientName = LogInUserName.Text;
                SetControlsVisibility(this,"login",false);
                SetControlsVisibility(this,"reg",false);
            }
            else
            {
                MessageBox.Show("Theres been an error in registering");
            }
        }

        private void GoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetControlsVisibility(this, "login", false);
            SetControlsVisibility(this, "reg", true);

        }
        private void BackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetControlsVisibility(this, "login", true);
            SetControlsVisibility(this, "reg", false);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SignupRequest request = new SignupRequest {
               username = RegisterUserName.Text,
               password = RegisterPassword.Text,
               mail = RegisterMail.Text
            };

            Arranger.client.SendRequest(11, request);
            StatusResponse response = Arranger.client.DeserializeResponse<StatusResponse>();

            if (response.status == 0)
            {
                terms.Visible = true;
                truebutton.Visible = false;
                Arranger.ClientName = RegisterUserName.Text;
                SetControlsVisibility(this, "login", false);
                SetControlsVisibility(this, "reg", false);
            }
            else
            {
                MessageBox.Show("Theres been an error in registering");
            }
        }

        private void termsandcondition_CheckedChanged(object sender, EventArgs e)
        {
            if(stupid.Checked && termsandcondition.Checked) 
            {
                Fakecontinue.Visible = false;
                truebutton.Visible = true;
            }
            else
            {
                Fakecontinue.Visible = true;
                truebutton.Visible = false;
            }
        }

        private void stupid_CheckedChanged(object sender, EventArgs e)
        {
            if (stupid.Checked && termsandcondition.Checked)
            {
                Fakecontinue.Visible = false;
                truebutton.Visible = true;
            }
            else
            {
                Fakecontinue.Visible = true;
                truebutton.Visible = false;
            }
        }

        private void truebutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            terms.Visible = false;
            SetControlsVisibility(this, "login", true);

            Arranger.MenuScreen.Location = this.Location;
            Arranger.MenuScreen.Size = this.Size;
            Arranger.MenuScreen.Visible = true;


        }
    }
}




