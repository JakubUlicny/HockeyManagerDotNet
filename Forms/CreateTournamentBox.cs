using HockeyManager.Forms;

namespace HockeyManager
{
    public partial class CreateTournamentBox : Form
    {
        private Dictionary<int, string> westernDictTeams = new();
        private Dictionary<int, string> easternDictTeams = new();
        private List<string> easternTeamList = new();
        private List<string> westernTeamList = new();
        private int _playoffRound;
        private int _selectedCount = 0;

        public CreateTournamentBox()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentBox_Load(object sender, EventArgs e)
        {

        }

        private async void Submit_ClickAsync(object sender, EventArgs e)
        {
            switch (_playoffRound)
            {
                case 2:
                    CupFinal form = new CupFinal(easternDictTeams, westernDictTeams);
                    form.Show();
                    break;
                case 16:
                    FirstRound firstRound = new FirstRound(easternDictTeams, westernDictTeams);
                    firstRound.Show();
                    break;
                default:
                    break;
            }

        }

        private void NumberOfTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            _playoffRound = (int)NumberOfTeams.SelectedItem;
            _selectedCount = 0;
            SubmitButton.Enabled = false;
            DisableTeamComboBox();
            westernDictTeams = new();
            easternDictTeams = new();
            if (_playoffRound == 16)
            {
                Western5.Enabled = true;
                Western6.Enabled = true;
                Western7.Enabled = true;
                Western8.Enabled = true;
                Eastern5.Enabled = true;
                Eastern6.Enabled = true;
                Eastern7.Enabled = true;
                Eastern8.Enabled = true;
            }
            if (_playoffRound >= 8)
            {
                Western3.Enabled = true;
                Western4.Enabled = true;
                Eastern3.Enabled = true;
                Eastern4.Enabled = true;
            }
            if (_playoffRound >= 4)
            {
                Western2.Enabled = true;
                Eastern2.Enabled = true;
            }
            if (_playoffRound >= 2)
            {
                Eastern1.Enabled = true;
                Western1.Enabled = true;
            }
        }

        private void DisableTeamComboBox()
        {
            foreach (var item in Controls.OfType<ComboBox>())
            {

                if (!item.Equals(NumberOfTeams))
                {
                    item.SelectedIndex = -1;
                    item.Enabled = false;
                }
            }
        }

        private async void ConferenceComboBox_VisibleChangedAsync(object sender, EventArgs e)
        {
            try
            {
                if (sender is not ComboBox box) throw new ArgumentException(nameof(box));
                box.Items.Clear();
                if (box.Tag.ToString().Contains('W'))
                {
                    if (westernTeamList.Count == 0)
                    {
                        westernTeamList = await UILogic.FillComboBoxWithTeams(false);
                    }
                    box.Items
                        .AddRange(
                        westernTeamList.ToArray()
                        );
                }
                else
                {
                    if (easternTeamList.Count == 0)
                    {
                        easternTeamList = await UILogic.FillComboBoxWithTeams(true);
                    }
                    box.Items
                        .AddRange(
                        easternTeamList.ToArray()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n" + ex.Message);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox box = sender as ComboBox;
                if (box.SelectedIndex == -1) return;
                string? tag = box.Tag.ToString();
                int lengthBefore, lengthAfter = 0;
                if (tag!.Contains('W'))
                {
                    lengthBefore = westernDictTeams.Count;
                    AddToDictionary(westernDictTeams, tag, box);
                    lengthAfter = westernDictTeams.Count;
                }
                else
                {
                    lengthBefore = easternDictTeams.Count;
                    AddToDictionary(easternDictTeams, tag, box);
                    lengthAfter = easternDictTeams.Count;
                }

                if (lengthAfter - lengthBefore == 1)
                {
                    _selectedCount++;
                }

                if (_playoffRound == _selectedCount &&
                    westernDictTeams.Values.Distinct().Count()
                    + easternDictTeams.Values.Distinct().Count() == _selectedCount)
                    
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\n" + ex.Message);
            }
        }

        private static void AddToDictionary(Dictionary<int, string> conferenceTeams, string? tag, ComboBox box)
        {
            try
            {
                int key = int.Parse(tag[1].ToString());
                if (conferenceTeams.ContainsKey(key))
                {
                    conferenceTeams[key] = box.SelectedItem.ToString();
                }
                else
                {
                    conferenceTeams.Add(key, box.SelectedItem.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
