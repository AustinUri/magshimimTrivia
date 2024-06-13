using System;

namespace TriviaUiTestII
{
    partial class CreateRoomScreen
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
            this.RoomName = new System.Windows.Forms.TextBox();
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.NumberOfPlayers_Bar = new System.Windows.Forms.HScrollBar();
            this.NumberOfQuestion_Bar = new System.Windows.Forms.HScrollBar();
            this.TimeToAnswer_Bar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfQuestions = new System.Windows.Forms.Label();
            this.timeToAnswer = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.fakeCreate = new System.Windows.Forms.Button();
            this.PlayersCount = new System.Windows.Forms.Label();
            this.StartBut = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.wait = new System.Windows.Forms.ListBox();
            this.TimePerQuestion = new System.Windows.Forms.Label();
            this.NumQuestions = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomName
            // 
            this.RoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomName.Location = new System.Drawing.Point(269, 105);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(238, 35);
            this.RoomName.TabIndex = 1;
            this.RoomName.Tag = "Create";
            this.RoomName.TextChanged += new System.EventHandler(this.RoomName_TextChanged);
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayersLabel.Location = new System.Drawing.Point(146, 163);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(47, 13);
            this.PlayersLabel.TabIndex = 6;
            this.PlayersLabel.Tag = "Create";
            this.PlayersLabel.Text = "Players: ";
            // 
            // NumberOfPlayers_Bar
            // 
            this.NumberOfPlayers_Bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfPlayers_Bar.Location = new System.Drawing.Point(149, 176);
            this.NumberOfPlayers_Bar.Name = "NumberOfPlayers_Bar";
            this.NumberOfPlayers_Bar.Size = new System.Drawing.Size(216, 32);
            this.NumberOfPlayers_Bar.TabIndex = 7;
            this.NumberOfPlayers_Bar.Tag = "Create";
            this.NumberOfPlayers_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NumberOfPlayers_Bar_Scroll);
            this.NumberOfPlayers_Bar.ValueChanged += new System.EventHandler(this.NumberOfPlayers_Bar_Scroll);
            // 
            // NumberOfQuestion_Bar
            // 
            this.NumberOfQuestion_Bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfQuestion_Bar.Location = new System.Drawing.Point(128, 270);
            this.NumberOfQuestion_Bar.Name = "NumberOfQuestion_Bar";
            this.NumberOfQuestion_Bar.Size = new System.Drawing.Size(216, 32);
            this.NumberOfQuestion_Bar.TabIndex = 8;
            this.NumberOfQuestion_Bar.Tag = "Create";
            this.NumberOfQuestion_Bar.ValueChanged += new System.EventHandler(this.NumberOfQuestion_Bar_Scroll);
            // 
            // TimeToAnswer_Bar
            // 
            this.TimeToAnswer_Bar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeToAnswer_Bar.Location = new System.Drawing.Point(423, 228);
            this.TimeToAnswer_Bar.Name = "TimeToAnswer_Bar";
            this.TimeToAnswer_Bar.Size = new System.Drawing.Size(216, 32);
            this.TimeToAnswer_Bar.TabIndex = 9;
            this.TimeToAnswer_Bar.Tag = "Create";
            this.TimeToAnswer_Bar.ValueChanged += new System.EventHandler(this.TimeToAnswer_Bar_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Tag = "Create";
            this.label1.Text = "Amount of question: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(420, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Tag = "Create";
            this.label2.Text = "Time for Question: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(346, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Tag = "Create";
            this.label3.Text = "Room Name:";
            // 
            // numberOfQuestions
            // 
            this.numberOfQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOfQuestions.AutoSize = true;
            this.numberOfQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.numberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfQuestions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberOfQuestions.Location = new System.Drawing.Point(317, 282);
            this.numberOfQuestions.Name = "numberOfQuestions";
            this.numberOfQuestions.Size = new System.Drawing.Size(27, 20);
            this.numberOfQuestions.TabIndex = 14;
            this.numberOfQuestions.Tag = "Create";
            this.numberOfQuestions.Text = "Xx";
            // 
            // timeToAnswer
            // 
            this.timeToAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToAnswer.AutoSize = true;
            this.timeToAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.timeToAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeToAnswer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeToAnswer.Location = new System.Drawing.Point(612, 240);
            this.timeToAnswer.Name = "timeToAnswer";
            this.timeToAnswer.Size = new System.Drawing.Size(27, 20);
            this.timeToAnswer.TabIndex = 15;
            this.timeToAnswer.Tag = "Create";
            this.timeToAnswer.Text = "Xx";
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create.Location = new System.Drawing.Point(329, 361);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(116, 31);
            this.create.TabIndex = 19;
            this.create.Tag = "Create";
            this.create.Text = "Create Room";
            this.create.UseVisualStyleBackColor = true;
            this.create.Visible = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // fakeCreate
            // 
            this.fakeCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fakeCreate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fakeCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fakeCreate.Font = new System.Drawing.Font("Aharoni", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fakeCreate.Location = new System.Drawing.Point(329, 363);
            this.fakeCreate.Name = "fakeCreate";
            this.fakeCreate.Size = new System.Drawing.Size(116, 31);
            this.fakeCreate.TabIndex = 20;
            this.fakeCreate.Tag = "Create";
            this.fakeCreate.Text = "Create Room";
            this.fakeCreate.UseVisualStyleBackColor = false;
            // 
            // PlayersCount
            // 
            this.PlayersCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayersCount.AutoSize = true;
            this.PlayersCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PlayersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersCount.Location = new System.Drawing.Point(338, 188);
            this.PlayersCount.Name = "PlayersCount";
            this.PlayersCount.Size = new System.Drawing.Size(27, 20);
            this.PlayersCount.TabIndex = 13;
            this.PlayersCount.Tag = "Create";
            this.PlayersCount.Text = "Xx";
            // 
            // StartBut
            // 
            this.StartBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartBut.Location = new System.Drawing.Point(329, 318);
            this.StartBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(116, 28);
            this.StartBut.TabIndex = 21;
            this.StartBut.Tag = "wait";
            this.StartBut.Text = "Start Game";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Visible = false;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // Num
            // 
            this.Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num.AutoSize = true;
            this.Num.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Num.Location = new System.Drawing.Point(674, 132);
            this.Num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(10, 13);
            this.Num.TabIndex = 25;
            this.Num.Tag = "wait";
            this.Num.Text = ".";
            this.Num.Visible = false;
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Time.Location = new System.Drawing.Point(674, 163);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(10, 13);
            this.Time.TabIndex = 26;
            this.Time.Tag = "wait";
            this.Time.Text = ".";
            this.Time.Visible = false;
            // 
            // wait
            // 
            this.wait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wait.FormattingEnabled = true;
            this.wait.Location = new System.Drawing.Point(56, 88);
            this.wait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(175, 251);
            this.wait.TabIndex = 27;
            this.wait.Tag = "wait";
            this.wait.Visible = false;
            // 
            // TimePerQuestion
            // 
            this.TimePerQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimePerQuestion.AutoSize = true;
            this.TimePerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePerQuestion.Location = new System.Drawing.Point(490, 124);
            this.TimePerQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimePerQuestion.Name = "TimePerQuestion";
            this.TimePerQuestion.Size = new System.Drawing.Size(168, 24);
            this.TimePerQuestion.TabIndex = 24;
            this.TimePerQuestion.Tag = "wait";
            this.TimePerQuestion.Text = "Time Per Question";
            this.TimePerQuestion.Visible = false;
            // 
            // NumQuestions
            // 
            this.NumQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumQuestions.AutoSize = true;
            this.NumQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumQuestions.Location = new System.Drawing.Point(469, 152);
            this.NumQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.Size = new System.Drawing.Size(193, 24);
            this.NumQuestions.TabIndex = 23;
            this.NumQuestions.Tag = "wait";
            this.NumQuestions.Text = "Number Of Questions";
            this.NumQuestions.Visible = false;
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::TriviaUiTestII.Properties.Resources._340;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 30);
            this.Back.TabIndex = 18;
            this.Back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TriviaUiTestII.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // CreateRoomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.TimePerQuestion);
            this.Controls.Add(this.NumQuestions);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.fakeCreate);
            this.Controls.Add(this.create);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.timeToAnswer);
            this.Controls.Add(this.numberOfQuestions);
            this.Controls.Add(this.PlayersCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeToAnswer_Bar);
            this.Controls.Add(this.NumberOfQuestion_Bar);
            this.Controls.Add(this.NumberOfPlayers_Bar);
            this.Controls.Add(this.PlayersLabel);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateRoomScreen";
            this.Text = "CreateRoomScreen";
            this.Load += new System.EventHandler(this.CreateRoomScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.HScrollBar NumberOfPlayers_Bar;
        private System.Windows.Forms.HScrollBar NumberOfQuestion_Bar;
        private System.Windows.Forms.HScrollBar TimeToAnswer_Bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberOfQuestions;
        private System.Windows.Forms.Label timeToAnswer;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button fakeCreate;
        private System.Windows.Forms.Label PlayersCount;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ListBox wait;
        private System.Windows.Forms.Label TimePerQuestion;
        private System.Windows.Forms.Label NumQuestions;
    }
}