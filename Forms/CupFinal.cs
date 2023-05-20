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
    public partial class CupFinal : Form
    {
        private Dictionary<int, string> _easternFinalist;
        private Dictionary<int, string> _westernFinalist;

        public CupFinal(Dictionary<int, string> easternTeam, Dictionary<int, string> westernTeam)
        {
            InitializeComponent();
            _easternFinalist = easternTeam;
            _westernFinalist = westernTeam;
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
                    if (tag.Count() == 2)
                    {
                        if (tag.Contains('W'))
                        {
                            label.Text = _westernFinalist[1];
                        }
                        else
                        {
                            label.Text = _easternFinalist[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void EasternScore_Click(object sender, EventArgs e)
        {
            easternScore.Text = (int.Parse(easternScore.Text) + 1).ToString();
            if (easternScore.Text.SequenceEqual("4"))
            {
                MessageBox.Show($"Team - {easternTeam.Text} won Stanley Cup! Congrats!");
            }
        }

        private void westernScore_Click(object sender, EventArgs e)
        {
            westernScore.Text = (int.Parse(westernScore.Text) + 1).ToString();
            if (westernScore.Text.SequenceEqual("4"))
            {
                MessageBox.Show($"Team - {easternTeam.Text} won Stanley Cup! Congrats!");
            }
        }
    }
}
