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
            createTournament = new Button();
            textBox1 = new TextBox();
            LoadTournament = new Button();
            addPlayer = new Button();
            addTeam = new Button();
            addTeamDialog = new OpenFileDialog();
            addPlayersDialog = new OpenFileDialog();
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
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.SkyBlue;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.MinimumSize = new Size(0, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1051, 25);
            textBox1.TabIndex = 4;
            textBox1.Text = "Hockey Manager!";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // LoadTournament
            // 
            LoadTournament.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoadTournament.BackColor = Color.DarkGray;
            LoadTournament.Location = new Point(658, 518);
            LoadTournament.Margin = new Padding(3, 4, 3, 4);
            LoadTournament.Name = "LoadTournament";
            LoadTournament.Size = new Size(208, 105);
            LoadTournament.TabIndex = 5;
            LoadTournament.Text = "Load Tournament";
            LoadTournament.UseVisualStyleBackColor = false;
            LoadTournament.Click += LoadTournament_Click;
            // 
            // addPlayer
            // 
            addPlayer.BackColor = Color.DarkGray;
            addPlayer.Location = new Point(658, 32);
            addPlayer.Margin = new Padding(3, 4, 3, 4);
            addPlayer.Name = "addPlayer";
            addPlayer.Size = new Size(208, 105);
            addPlayer.TabIndex = 6;
            addPlayer.Text = "Add Player/s";
            addPlayer.UseVisualStyleBackColor = false;
            addPlayer.Click += addPlayer_ClickAsync;
            // 
            // addTeam
            // 
            addTeam.BackColor = Color.DarkGray;
            addTeam.Location = new Point(187, 32);
            addTeam.Margin = new Padding(3, 4, 3, 4);
            addTeam.Name = "addTeam";
            addTeam.Size = new Size(208, 105);
            addTeam.TabIndex = 7;
            addTeam.Text = "Add Team/s";
            addTeam.UseVisualStyleBackColor = false;
            addTeam.Click += addTeam_Click;
            // 
            // addTeamDialog
            // 
            addTeamDialog.FileName = "addTeamDialog";
            // 
            // addPlayersDialog
            // 
            addPlayersDialog.FileName = "addPlayersDialog";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = Properties.Resources.bracket;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 638);
            Controls.Add(addTeam);
            Controls.Add(addPlayer);
            Controls.Add(LoadTournament);
            Controls.Add(textBox1);
            Controls.Add(createTournament);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Hockey Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button createTournament;
        protected internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LoadTournament;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button addTeam;
        private System.Windows.Forms.OpenFileDialog addTeamDialog;
        private System.Windows.Forms.OpenFileDialog addPlayersDialog;
    }
}

