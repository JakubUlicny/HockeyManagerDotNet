using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyManager
{
    public partial class DeleteForm : Form
    {
        private Main _main;
        public DeleteForm(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteTeamInputField_TextChanged(object sender, EventArgs e)
        {
            if (DeleteTeamInputField.Text.SequenceEqual(""))
            {
                SubmitTeamNameButton.Enabled = false;
                DeletePlayerInputField.Enabled = true;
            }
            else
            {
                SubmitTeamNameButton.Enabled = true;
                DeletePlayerInputField.Enabled = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeletePlayerInputField_TextChanged(object sender, EventArgs e)
        {
            if (DeletePlayerInputField.Text.SequenceEqual(""))
            {
                SubmitPlayerNameButton.Enabled = false;
                DeleteTeamInputField.Enabled = true;
            }
            else
            {
                SubmitPlayerNameButton.Enabled = true;
                DeleteTeamInputField.Enabled = false;
            }
        }

        private async void SubmitTeamNameButton_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (await await Task.Factory.StartNew(() => new SubmitParser().TeamInputParserAsync(DeleteTeamInputField.Text.Trim())))
                {
                    MessageBox.Show($"We deleted {DeleteTeamInputField.Text} from DB.");
                    _main.OnTeamChange();
                }
                else
                {
                    MessageBox.Show($"We couldn't delete {DeleteTeamInputField.Text} from DB.");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Team is not in DB.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void SubmitPlayerNameButton_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (await await Task.Factory.StartNew(() => new SubmitParser().PlayerInputParserAsync(DeletePlayerInputField.Text.Trim())))
                {
                    MessageBox.Show($"We deleted {DeletePlayerInputField.Text} from DB.");
                }
                else
                {
                    MessageBox.Show($"We couldn't delete {DeletePlayerInputField.Text} from DB.");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The player with name {DeletePlayerInputField.Text} is not in DB.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
