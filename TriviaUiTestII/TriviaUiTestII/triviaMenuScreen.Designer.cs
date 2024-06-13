namespace TriviaUiTestII
{
    partial class triviaMenuScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triviaMenuScreen));
            this.ExitOrLogOut = new System.Windows.Forms.Button();
            this.GetUserStatistics = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.FindRooms = new System.Windows.Forms.Button();
            this.CreateRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WelcomeStat = new System.Windows.Forms.Label();
            this.totalAns = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Score = new System.Windows.Forms.Label();
            this.TotalGames = new System.Windows.Forms.Label();
            this.correctAns = new System.Windows.Forms.Label();
            this.avgAns = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.USER5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.USER4 = new System.Windows.Forms.Label();
            this.USER3 = new System.Windows.Forms.Label();
            this.USER2 = new System.Windows.Forms.Label();
            this.USER1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1394, 632);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            // 
            // ExitOrLogOut
            // 
            this.ExitOrLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitOrLogOut.Location = new System.Drawing.Point(581, 485);
            this.ExitOrLogOut.Name = "ExitOrLogOut";
            this.ExitOrLogOut.Size = new System.Drawing.Size(229, 77);
            this.ExitOrLogOut.TabIndex = 1;
            this.ExitOrLogOut.Tag = "TriviaMenu";
            this.ExitOrLogOut.Text = "Exit:(";
            this.ExitOrLogOut.UseVisualStyleBackColor = true;
            this.ExitOrLogOut.Click += new System.EventHandler(this.ExitOrLogOut_Click);
            // 
            // GetUserStatistics
            // 
            this.GetUserStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetUserStatistics.Location = new System.Drawing.Point(581, 319);
            this.GetUserStatistics.Name = "GetUserStatistics";
            this.GetUserStatistics.Size = new System.Drawing.Size(229, 77);
            this.GetUserStatistics.TabIndex = 2;
            this.GetUserStatistics.Tag = "TriviaMenu";
            this.GetUserStatistics.Text = "My Statistics";
            this.GetUserStatistics.UseVisualStyleBackColor = true;
            this.GetUserStatistics.Click += new System.EventHandler(this.GetUserStatistics_Click);
            // 
            // Statistics
            // 
            this.Statistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Statistics.Location = new System.Drawing.Point(581, 402);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(229, 77);
            this.Statistics.TabIndex = 3;
            this.Statistics.Tag = "TriviaMenu";
            this.Statistics.Text = "High Scores";
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // FindRooms
            // 
            this.FindRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindRooms.Location = new System.Drawing.Point(581, 236);
            this.FindRooms.Name = "FindRooms";
            this.FindRooms.Size = new System.Drawing.Size(229, 77);
            this.FindRooms.TabIndex = 5;
            this.FindRooms.Tag = "TriviaMenu";
            this.FindRooms.Text = "Find Rooms";
            this.FindRooms.UseVisualStyleBackColor = true;
            this.FindRooms.Click += new System.EventHandler(this.FindRooms_Click);
            // 
            // CreateRoom
            // 
            this.CreateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateRoom.Location = new System.Drawing.Point(581, 153);
            this.CreateRoom.Name = "CreateRoom";
            this.CreateRoom.Size = new System.Drawing.Size(229, 77);
            this.CreateRoom.TabIndex = 6;
            this.CreateRoom.Tag = "TriviaMenu";
            this.CreateRoom.Text = "Create Room";
            this.CreateRoom.UseVisualStyleBackColor = true;
            this.CreateRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Location = new System.Drawing.Point(235, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 355);
            this.panel1.TabIndex = 8;
            this.panel1.Tag = "TriviaMenu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.Image = global::TriviaUiTestII.Properties.Resources.depositphotos_38585251_stock_photo_unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(17, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // welcome
            // 
            this.welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(29, 13);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(213, 27);
            this.welcome.TabIndex = 3;
            this.welcome.Tag = "TriviaMenu";
            this.welcome.Text = "Welcome \"User\"";
            // 
            // LogOut
            // 
            this.LogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogOut.Location = new System.Drawing.Point(34, 307);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(194, 45);
            this.LogOut.TabIndex = 2;
            this.LogOut.Tag = "TriviaMenu";
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(871, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 355);
            this.panel2.TabIndex = 20;
            this.panel2.Tag = "TriviaMenu";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox3.Image = global::TriviaUiTestII.Properties.Resources.question;
            this.pictureBox3.Location = new System.Drawing.Point(19, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 243);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 27);
            this.label1.TabIndex = 0;
            this.label1.Tag = "TriviaMenu";
            this.label1.Text = "Todays Daily picture";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(234, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 5);
            this.panel3.TabIndex = 4;
            this.panel3.Tag = "TriviaMenu";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(870, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 5);
            this.panel4.TabIndex = 5;
            this.panel4.Tag = "TriviaMenu";
            // 
            // WelcomeStat
            // 
            this.WelcomeStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeStat.AutoSize = true;
            this.WelcomeStat.Font = new System.Drawing.Font("Aharoni", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeStat.Location = new System.Drawing.Point(30, 42);
            this.WelcomeStat.Name = "WelcomeStat";
            this.WelcomeStat.Size = new System.Drawing.Size(361, 35);
            this.WelcomeStat.TabIndex = 0;
            this.WelcomeStat.Tag = "Statistic";
            this.WelcomeStat.Text = "Personal \"user\" Stats";
            this.WelcomeStat.Visible = false;
            // 
            // totalAns
            // 
            this.totalAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalAns.AutoSize = true;
            this.totalAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAns.Location = new System.Drawing.Point(16, 131);
            this.totalAns.Name = "totalAns";
            this.totalAns.Size = new System.Drawing.Size(178, 26);
            this.totalAns.TabIndex = 1;
            this.totalAns.Tag = "Statistic";
            this.totalAns.Text = "Total Answers: xx";
            this.totalAns.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Score);
            this.panel6.Controls.Add(this.TotalGames);
            this.panel6.Controls.Add(this.correctAns);
            this.panel6.Controls.Add(this.avgAns);
            this.panel6.Controls.Add(this.WelcomeStat);
            this.panel6.Controls.Add(this.totalAns);
            this.panel6.Location = new System.Drawing.Point(469, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 481);
            this.panel6.TabIndex = 2;
            this.panel6.Tag = "Statistic";
            this.panel6.Visible = false;
            // 
            // Score
            // 
            this.Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Score.AutoSize = true;
            this.Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(105, 370);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(89, 26);
            this.Score.TabIndex = 5;
            this.Score.Tag = "Statistic";
            this.Score.Text = "SCORE:";
            this.Score.Visible = false;
            // 
            // TotalGames
            // 
            this.TotalGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalGames.AutoSize = true;
            this.TotalGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGames.Location = new System.Drawing.Point(16, 256);
            this.TotalGames.Name = "TotalGames";
            this.TotalGames.Size = new System.Drawing.Size(232, 26);
            this.TotalGames.TabIndex = 4;
            this.TotalGames.Tag = "Statistic";
            this.TotalGames.Text = "Total Games Played: xx";
            this.TotalGames.Visible = false;
            // 
            // correctAns
            // 
            this.correctAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correctAns.AutoSize = true;
            this.correctAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAns.Location = new System.Drawing.Point(16, 212);
            this.correctAns.Name = "correctAns";
            this.correctAns.Size = new System.Drawing.Size(193, 26);
            this.correctAns.TabIndex = 3;
            this.correctAns.Tag = "Statistic";
            this.correctAns.Text = "Correct Answes: xx";
            this.correctAns.Visible = false;
            // 
            // avgAns
            // 
            this.avgAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avgAns.AutoSize = true;
            this.avgAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgAns.Location = new System.Drawing.Point(16, 173);
            this.avgAns.Name = "avgAns";
            this.avgAns.Size = new System.Drawing.Size(249, 26);
            this.avgAns.TabIndex = 2;
            this.avgAns.Tag = "Statistic";
            this.avgAns.Text = "Averge answer Time: xxs";
            this.avgAns.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.USER5);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.USER4);
            this.panel5.Controls.Add(this.USER3);
            this.panel5.Controls.Add(this.USER2);
            this.panel5.Controls.Add(this.USER1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(451, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 481);
            this.panel5.TabIndex = 21;
            this.panel5.Tag = "highS";
            this.panel5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 26;
            this.label4.Tag = "highS";
            this.label4.Text = "First Place!!! ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::TriviaUiTestII.Properties.Resources.Cyber_Awards;
            this.pictureBox4.Location = new System.Drawing.Point(291, 264);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(142, 178);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "highS";
            this.pictureBox4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 19);
            this.label3.TabIndex = 24;
            this.label3.Tag = "highS";
            this.label3.Text = "The ones that don\'t matter";
            // 
            // USER5
            // 
            this.USER5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USER5.AutoSize = true;
            this.USER5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER5.Location = new System.Drawing.Point(22, 411);
            this.USER5.Name = "USER5";
            this.USER5.Size = new System.Drawing.Size(253, 31);
            this.USER5.TabIndex = 5;
            this.USER5.Tag = "highS";
            this.USER5.Text = "1. \"USER\" \"SCORE\" ";
            this.USER5.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::TriviaUiTestII.Properties.Resources.Cyber_Awards;
            this.pictureBox5.Location = new System.Drawing.Point(352, 128);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 85);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "highS";
            // 
            // USER4
            // 
            this.USER4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USER4.AutoSize = true;
            this.USER4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER4.Location = new System.Drawing.Point(22, 362);
            this.USER4.Name = "USER4";
            this.USER4.Size = new System.Drawing.Size(253, 31);
            this.USER4.TabIndex = 4;
            this.USER4.Tag = "highS";
            this.USER4.Text = "1. \"USER\" \"SCORE\" ";
            this.USER4.Visible = false;
            // 
            // USER3
            // 
            this.USER3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USER3.AutoSize = true;
            this.USER3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER3.Location = new System.Drawing.Point(22, 313);
            this.USER3.Name = "USER3";
            this.USER3.Size = new System.Drawing.Size(253, 31);
            this.USER3.TabIndex = 3;
            this.USER3.Tag = "highS";
            this.USER3.Text = "1. \"USER\" \"SCORE\" ";
            this.USER3.Visible = false;
            // 
            // USER2
            // 
            this.USER2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USER2.AutoSize = true;
            this.USER2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER2.Location = new System.Drawing.Point(22, 264);
            this.USER2.Name = "USER2";
            this.USER2.Size = new System.Drawing.Size(253, 31);
            this.USER2.TabIndex = 2;
            this.USER2.Tag = "highS";
            this.USER2.Text = "1. \"USER\" \"SCORE\" ";
            this.USER2.Visible = false;
            // 
            // USER1
            // 
            this.USER1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USER1.AutoSize = true;
            this.USER1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USER1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER1.Location = new System.Drawing.Point(14, 154);
            this.USER1.Name = "USER1";
            this.USER1.Size = new System.Drawing.Size(332, 39);
            this.USER1.TabIndex = 1;
            this.USER1.Tag = "highS";
            this.USER1.Text = "1. \"USER\" \"SCORE\" ";
            this.USER1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 36);
            this.label2.TabIndex = 0;
            this.label2.Tag = "highS";
            this.label2.Text = "TOP SCORES!";
            this.label2.Visible = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Back.BackgroundImage = global::TriviaUiTestII.Properties.Resources._340;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 30);
            this.Back.TabIndex = 19;
            this.Back.Tag = "backButton";
            this.Back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Location = new System.Drawing.Point(1307, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 22;
            this.Refresh.Tag = "FindRoom";
            this.Refresh.Text = "Refresh";
            this.Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Visible = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // triviaMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1394, 632);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateRoom);
            this.Controls.Add(this.FindRooms);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.GetUserStatistics);
            this.Controls.Add(this.ExitOrLogOut);
            this.Controls.Add(this.panel6);
            this.Controls.Add(pictureBox1);
            this.Name = "triviaMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.triviaMenuScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitOrLogOut;
        private System.Windows.Forms.Button GetUserStatistics;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button FindRooms;
        private System.Windows.Forms.Button CreateRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label WelcomeStat;
        private System.Windows.Forms.Label totalAns;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label TotalGames;
        private System.Windows.Forms.Label correctAns;
        private System.Windows.Forms.Label avgAns;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label USER5;
        private System.Windows.Forms.Label USER4;
        private System.Windows.Forms.Label USER3;
        private System.Windows.Forms.Label USER2;
        private System.Windows.Forms.Label USER1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Refresh;
    }
}