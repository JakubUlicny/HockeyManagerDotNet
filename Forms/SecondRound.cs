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
    public partial class SecondRound : Form
    {
        private Dictionary<int, string> _easternTeams;
        private Dictionary<int, string> _westernTeams;
        private Dictionary<int, string> _easternTeamNames = new();
        private Dictionary<int, string> _westernTeamNames = new();
        public SecondRound(Dictionary<int, string> easternTeam, Dictionary<int, string> westernTeam)
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
                string scoreTag = score.Tag.ToString();
                int key = int.Parse(scoreTag[1].ToString());
                int opositeNum = 5 - key;
                Label opositeLabel = (Label)Controls.Find($"{scoreTag[0]}Score{opositeNum}", true).First();

                if (opositeLabel.Text.SequenceEqual("4") || score.Text.SequenceEqual("4")) return;


                score.Text = (int.Parse(score.Text) + 1).ToString();
                if (score.Text.SequenceEqual("4"))
                {
                    foreach (var item in Controls)
                    {
                        if (item.GetType() != typeof(Label))
                        {
                            continue;
                        }
                        Label label = (Label)item;
                        if (label.Tag.ToString().SequenceEqual($"{scoreTag[0]}{scoreTag[1]}Sc"))
                        {
                            AddWinningTeam(key, scoreTag[0]);
                            if (_easternTeamNames.Count + _westernTeamNames.Count == 4)
                            {
                                NextRound.Enabled = true;
                            }
                            break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void AddWinningTeam(int key, char conference)
        {
            int oldKey = key;
            if (key > 2)
            {
                switch (key)
                {
                    case 4: key = 1; break;
                    case 3: key = 2; break;
                }
            }
            if (conference.Equals('E')) _easternTeamNames.Add(key, _easternTeams[oldKey]);
            else _westernTeamNames.Add(key, _westernTeams[oldKey]);
        }

        private void NextRound_Click(object sender, EventArgs e)
        {
            ConferenceFinals conferenceFinals = new ConferenceFinals(_easternTeamNames, _westernTeamNames);
            conferenceFinals.Show();
        }
    }
}
