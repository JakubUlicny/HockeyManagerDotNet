using HockeyManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyManager
{
    public partial class Main : Form
    {
        private Form createTournamentForm;
        private Form deleteForm;

        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if (createTournamentForm == null || createTournamentForm.Text == "")
            {
                createTournamentForm = new CreateTournamentBox();
            }
            createTournamentForm.Show();
        }

        private async void addTeam_Click(object sender, EventArgs e)
        {
            if (addTeamDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await Task.Factory.StartNew(() => Create.AddTeamAsync(new StreamReader(addTeamDialog.FileName)));
                    MessageBox.Show("Team(s) were added!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Teams cannot be inserted\n" + ex.Message);
                }
                finally
                {
                    OnTeamChange();
                }
            }
        }

        private async void addPlayer_ClickAsync(object sender, EventArgs e)
        {
            if (addPlayersDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await Task.Factory.StartNew(() => Create.AddPlayersAsync(new StreamReader(addPlayersDialog.FileName)));
                    MessageBox.Show("Players were added!\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Players cannot be inserted" + ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (deleteForm == null || deleteForm.Text == "")
            {
                deleteForm = new DeleteForm(this);
            }
            deleteForm.Show();
        }

        public void OnTeamChange()
        {
            SelectTeamBox.Items.Clear();
            SelectTeamBox.Items.AddRange(LoadTeamsToComboBox());
        }

        private string[] LoadTeamsToComboBox()
        {
            string[] str = UILogic.FillComboBoxWithTeams();
            return str;
        }
    }
}
