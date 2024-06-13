using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaUiTestII
{
    public partial class PersonalStatsScreen : Form
    {
        public PersonalStatsScreen()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Arranger.PersonalStatsS.Location = this.Location;
            Arranger.MenuScreen.Size = this.Size;
            Arranger.MenuScreen.Visible = true;
        }

    }
}
