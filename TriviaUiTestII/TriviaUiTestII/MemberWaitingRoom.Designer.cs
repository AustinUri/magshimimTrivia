namespace TriviaUiTestII
{
    partial class MemberWaitingRoom
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BACK = new System.Windows.Forms.Button();
            this.players_title_lable = new System.Windows.Forms.Label();
            this.Time_title_label = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Number_title_label = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(77, 157);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 251);
            this.listBox1.TabIndex = 0;
            // 
            // BACK
            // 
            this.BACK.BackgroundImage = global::TriviaUiTestII.Properties.Resources._340;
            this.BACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BACK.Location = new System.Drawing.Point(11, 11);
            this.BACK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(48, 25);
            this.BACK.TabIndex = 1;
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // players_title_lable
            // 
            this.players_title_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.players_title_lable.AutoSize = true;
            this.players_title_lable.Location = new System.Drawing.Point(74, 133);
            this.players_title_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.players_title_lable.Name = "players_title_lable";
            this.players_title_lable.Size = new System.Drawing.Size(60, 13);
            this.players_title_lable.TabIndex = 2;
            this.players_title_lable.Text = "Players List";
            // 
            // Time_title_label
            // 
            this.Time_title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time_title_label.AutoSize = true;
            this.Time_title_label.Location = new System.Drawing.Point(426, 157);
            this.Time_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_title_label.Name = "Time_title_label";
            this.Time_title_label.Size = new System.Drawing.Size(94, 13);
            this.Time_title_label.TabIndex = 3;
            this.Time_title_label.Text = "Time Per Question";
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(539, 157);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(10, 13);
            this.Time.TabIndex = 4;
            this.Time.Text = ".";
            // 
            // Number_title_label
            // 
            this.Number_title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Number_title_label.AutoSize = true;
            this.Number_title_label.Location = new System.Drawing.Point(426, 184);
            this.Number_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Number_title_label.Name = "Number_title_label";
            this.Number_title_label.Size = new System.Drawing.Size(108, 13);
            this.Number_title_label.TabIndex = 5;
            this.Number_title_label.Text = "Number Of Questions";
            // 
            // Num
            // 
            this.Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(539, 184);
            this.Num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(10, 13);
            this.Num.TabIndex = 8;
            this.Num.Text = ".";
            // 
            // MemberWaitingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::TriviaUiTestII.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 522);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Number_title_label);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Time_title_label);
            this.Controls.Add(this.players_title_lable);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberWaitingRoom";
            this.Text = "MemberWaitingRoom";
            this.Load += new System.EventHandler(this.MemberWaitingRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Label players_title_lable;
        private System.Windows.Forms.Label Time_title_label;
        public System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Number_title_label;
        public System.Windows.Forms.Label Num;
    }
}