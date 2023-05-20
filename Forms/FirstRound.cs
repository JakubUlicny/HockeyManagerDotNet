using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyManager.Forms
{
    public partial class FirstRound : Form
    {
        private Dictionary<int, string> _easternTeams;
        private Dictionary<int, string> _westernTeams;
        private Dictionary<int, string> teamNames = new();

        public FirstRound(Dictionary<int, string> easternTeam, Dictionary<int, string> westernTeam)
        {
            InitializeComponent();
            _easternTeams = easternTeam;
            _westernTeams = westernTeam;
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            try
            {
                foreach (var item in Controls)
                {
                    if (item.GetType() != typeof(Label))
                    {
                        continue;
                    }

                    Label label = (Label)item;
                    string tag = label.Tag.ToString();
                    if (tag.Length == 3)
                    {
                        if (tag[0].Equals('W'))
                        {
                            label.Text = _westernTeams[int.Parse(tag[2].ToString())];
                        }
                        else
                        {
                            label.Text = _easternTeams[int.Parse(tag[2].ToString())];
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something went wrong\n" + ex.Message);
            }
        }

    private void Score_Click(object sender, EventArgs e)
        {
            try
            {

                Label score = (Label)sender;
                score.Text = (int.Parse(score.Text) + 1).ToString();
                if (score.Text.SequenceEqual("4"))
                {
                    string scoreTag = score.Tag.ToString();
                    foreach (var item in Controls)
                    {
                        if (item.GetType() != typeof(Label))
                        {
                            continue;
                        }
                        Label label = (Label)item;
                        if (label.Tag.ToString().SequenceEqual($"{scoreTag[0]}T{scoreTag[1]}")) 
                        {
                            AddWinningTeam(label.Text, int.Parse(scoreTag[1].ToString()), scoreTag[0]);
                            break;
                        }
                        label.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void AddWinningTeam(string teamName, int key, char conference)
        {
            int opositeNum = 9 - key;
            Label label = (Label)Controls.Find($"{conference}Score{opositeNum}", false).First();
            label.Enabled = false;
            if (key > 4)
            {
                switch (key)
                {
                    case 8:key = 1;break;
                    case 7: key = 2; break;
                    case 6: key = 3; break;
                    case 5: key = 4; break;
                }
            }
            teamNames.Add(key, teamName);
        }

        private void WScore2_Click(object sender, EventArgs e)
        {
        }

        private void WScore3_Click(object sender, EventArgs e)
        {
        }

        private void WScore4_Click(object sender, EventArgs e)
        {
        }

        private void WScore8_Click(object sender, EventArgs e)
        {
        }

        private void Wscore7_Click(object sender, EventArgs e)
        {
        }

        private void WScore6_Click(object sender, EventArgs e)
        {
        }

        private void W5Sc_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void label32_Click(object sender, EventArgs e)
        {
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void WScore1_Click(object sender, EventArgs e)
        {
        }

        private void label30_Click(object sender, EventArgs e)
        {
        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }
    }
}
