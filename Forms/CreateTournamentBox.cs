namespace HockeyManager
{
    public partial class CreateTournamentBox : Form
    {
        private Dictionary<int, string> westernSelectedTeams = new();
        private Dictionary<int, string> easternSelectedTeams = new();
        private List<string> easternTeamList = new();
        private List<string> westernTeamList = new();
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
            DisableTeamComboBox();
            int numOfSelected = (int)NumberOfTeams.SelectedItem;
            if (numOfSelected == 16)
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
            if (numOfSelected >= 8)
            {
                Western3.Enabled = true;
                Western4.Enabled = true;
                Eastern3.Enabled = true;
                Eastern4.Enabled = true;
            }
            if (numOfSelected >= 4)
            {
                Western2.Enabled = true;
                Eastern2.Enabled = true;
            }
            if (numOfSelected >= 2)
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
                    item.Enabled = false;
                }
            }
        }

        private async void ConferenceComboBox_VisibleChangedAsync(object sender, EventArgs e)
        {
            try
            {
                ComboBox box = sender as ComboBox;
                if (box == null) throw new ArgumentException(nameof(box));
                box.Items.Clear();
                if (box.Tag.ToString().Contains('W'))
                {
                    if (westernTeamList.Count == 0)
                    {
                        westernTeamList = await UILogic.FillComboBoxWithTeams(false);
                    }
                    box.Items
                        .AddRange(
                        westernTeamList
                        .Except(westernSelectedTeams.Values)
                        .ToArray()
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
                        easternTeamList
                        .Except(easternSelectedTeams.Values)
                        .ToArray()
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
                string? tag = box.Tag.ToString();
                if (tag!.Contains('W'))
                {
                    AddToDictionary(westernSelectedTeams, tag, box);
                }
                else
                {
                    AddToDictionary(easternSelectedTeams, tag, box);
                }

                foreach (var item in Controls)
                {
                    if (item.GetType() == typeof(ComboBox))
                    {
                        ComboBox? comboBox = item as ComboBox;
                        if (comboBox.Tag.ToString().Contains('W'))
                        {
                            comboBox.Items
                                .AddRange(
                                westernTeamList
                                .Except(westernSelectedTeams.Values)
                                .ToArray()
                                );
                        }
                        else
                        {
                            comboBox.Items
                                .AddRange(
                                easternTeamList
                                .Except(easternSelectedTeams.Values)
                                .ToArray()
                                );
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\n" + ex.Message);
            }
        }

        private void AddToDictionary(Dictionary<int, string> conferenceTeams, string? tag, ComboBox box)
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
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
