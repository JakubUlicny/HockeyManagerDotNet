namespace HockeyManager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            createTournament = new Button();
            DeleteButton = new Button();
            addPlayer = new Button();
            addTeams = new Button();
            addTeamDialog = new OpenFileDialog();
            addPlayersDialog = new OpenFileDialog();
            label1 = new Label();
            SelectTeamBox = new ComboBox();
            secondBindingSource = new BindingSource(components);
            secondBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)secondBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // createTournament
            // 
            createTournament.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            createTournament.BackColor = Color.DarkGray;
            createTournament.Location = new Point(187, 518);
            createTournament.Margin = new Padding(3, 4, 3, 4);
            createTournament.Name = "createTournament";
            createTournament.Size = new Size(208, 105);
            createTournament.TabIndex = 3;
            createTournament.Text = "Create Tournament";
            createTournament.UseVisualStyleBackColor = false;
            createTournament.Click += createTournamentButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DeleteButton.BackColor = Color.DarkGray;
            DeleteButton.Location = new Point(658, 518);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(208, 105);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete Menu";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addPlayer
            // 
            addPlayer.BackColor = Color.DarkGray;
            addPlayer.Enabled = false;
            addPlayer.Location = new Point(658, 32);
            addPlayer.Margin = new Padding(3, 4, 3, 4);
            addPlayer.Name = "addPlayer";
            addPlayer.Size = new Size(208, 105);
            addPlayer.TabIndex = 6;
            addPlayer.Text = "Add Player/s";
            addPlayer.UseVisualStyleBackColor = false;
            addPlayer.Click += addPlayer_ClickAsync;
            // 
            // addTeams
            // 
            addTeams.BackColor = Color.DarkGray;
            addTeams.Location = new Point(187, 32);
            addTeams.Margin = new Padding(3, 4, 3, 4);
            addTeams.Name = "addTeams";
            addTeams.Size = new Size(208, 105);
            addTeams.TabIndex = 7;
            addTeams.Text = "Add Teams";
            addTeams.UseVisualStyleBackColor = false;
            addTeams.Click += addTeam_Click;
            // 
            // addTeamDialog
            // 
            addTeamDialog.FileName = "addTeamDialog";
            // 
            // addPlayersDialog
            // 
            addPlayersDialog.FileName = "addPlayersDialog";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(398, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 40);
            label1.TabIndex = 8;
            label1.Text = "Hockey Manager!";
            // 
            // SelectTeamBox
            // 
            SelectTeamBox.FormattingEnabled = true;
            SelectTeamBox.Items.AddRange(LoadTeamsToComboBox());
            SelectTeamBox.Location = new Point(693, 144);
            SelectTeamBox.Name = "SelectTeamBox";
            SelectTeamBox.Size = new Size(151, 28);
            SelectTeamBox.TabIndex = 9;
            SelectTeamBox.SelectedIndexChanged += SelectTeamBox_SelectedIndexChanged;
            // 
            // secondBindingSource
            // 
            secondBindingSource.DataSource = typeof(Migrations.Second);
            // 
            // secondBindingSource1
            // 
            secondBindingSource1.DataSource = typeof(Migrations.Second);
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = Properties.Resources.bracket;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 638);
            Controls.Add(SelectTeamBox);
            Controls.Add(label1);
            Controls.Add(addTeams);
            Controls.Add(addPlayer);
            Controls.Add(DeleteButton);
            Controls.Add(createTournament);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Hockey Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)secondBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button createTournament;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button addTeams;
        private System.Windows.Forms.OpenFileDialog addTeamDialog;
        private System.Windows.Forms.OpenFileDialog addPlayersDialog;
        private Label label1;
        private ComboBox SelectTeamBox;
        private BindingSource secondBindingSource;
        private BindingSource secondBindingSource1;
    }
}

