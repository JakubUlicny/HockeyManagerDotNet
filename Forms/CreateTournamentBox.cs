using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyManager
{
    public partial class CreateTournamentBox : Form
    {
        public CreateTournamentBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentBox_Load(object sender, EventArgs e)
        {

        }

        private async void Submit_ClickAsync(object sender, EventArgs e)
        {
            int numOfTeams = 16;
            if (NumberOfTeams.SelectedItem != null)
            {
                numOfTeams = (int)NumberOfTeams.SelectedItem;
            }
            await Task.Factory.StartNew(() => CreateTournamentLogic.CreateTournamentAsync(numOfTeams));

        }

        private void NumberOfTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}
