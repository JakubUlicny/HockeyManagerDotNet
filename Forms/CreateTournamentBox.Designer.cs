namespace HockeyManager
{
    partial class CreateTournamentBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentBox));
            CreateTournamentHeading = new Label();
            label1 = new Label();
            NumberOfTeams = new ComboBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentHeading
            // 
            CreateTournamentHeading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CreateTournamentHeading.AutoSize = true;
            CreateTournamentHeading.BackColor = Color.Transparent;
            CreateTournamentHeading.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CreateTournamentHeading.ForeColor = Color.AliceBlue;
            CreateTournamentHeading.Location = new Point(1, 29);
            CreateTournamentHeading.Name = "CreateTournamentHeading";
            CreateTournamentHeading.Size = new Size(270, 31);
            CreateTournamentHeading.TabIndex = 0;
            CreateTournamentHeading.Text = "Create Your Tournament";
            CreateTournamentHeading.TextAlign = ContentAlignment.TopCenter;
            CreateTournamentHeading.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(33, 351);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 2;
            label1.Text = "Number Of Teams";
            // 
            // NumberOfTeams
            // 
            NumberOfTeams.BackColor = SystemColors.ButtonFace;
            NumberOfTeams.DisplayMember = "yes";
            NumberOfTeams.DrawMode = DrawMode.OwnerDrawVariable;
            NumberOfTeams.DropDownHeight = 200;
            NumberOfTeams.FlatStyle = FlatStyle.Popup;
            NumberOfTeams.ForeColor = Color.Navy;
            NumberOfTeams.FormattingEnabled = true;
            NumberOfTeams.IntegralHeight = false;
            NumberOfTeams.ItemHeight = 20;
            NumberOfTeams.Items.AddRange(new object[] { "2", "4", "8", "16" });
            NumberOfTeams.Location = new Point(33, 396);
            NumberOfTeams.MinimumSize = new Size(200, 0);
            NumberOfTeams.Name = "NumberOfTeams";
            NumberOfTeams.Size = new Size(204, 26);
            NumberOfTeams.TabIndex = 3;
            NumberOfTeams.SelectedIndexChanged += NumberOfTeams_SelectedIndexChanged;
            // 
            // SubmitButton
            // 
            SubmitButton.Enabled = false;
            SubmitButton.Location = new Point(694, 409);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += Submit_ClickAsync;
            // 
            // CreateTournamentBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo_teams;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitButton);
            Controls.Add(NumberOfTeams);
            Controls.Add(label1);
            Controls.Add(CreateTournamentHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTournamentBox";
            Text = "CreateTournamentBox";
            Load += CreateTournamentBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTournamentHeading;
        private Label label1;
        private ComboBox NumberOfTeams;
        private Button SubmitButton;
    }
}