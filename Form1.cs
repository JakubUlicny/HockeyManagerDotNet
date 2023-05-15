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
    public partial class Form1 : Form
    {
        private Form createTournamentForm;
        public Form1()
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
                createTournamentForm = new Form2();
            }
            createTournamentForm.Show();
        }

        private void LoadTournament_Click(object sender, EventArgs e)
        { }

        private void AddPlayers_Click(object sender, EventArgs e)
        {
            if (addPlayersDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //await PlayerDBContext.AddPlayerAsync(new StreamReader(addPlayersDialog.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Players cannot be inserted" + ex.Message);
                }
            }
        }

        private void addTeam_Click(object sender, EventArgs e)
        {
            if (addTeamDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //await TeamDBContext.AddTeamAsync(new StreamReader(addTeamDialog.FileName));
                    MessageBox.Show("Team(s) were added!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Teams cannot be inserted\n" + ex.Message);
                }
            }
        }
    }
}
