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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentBox));
            CreateTournamentHeading = new Label();
            label1 = new Label();
            NumberOfTeams = new ComboBox();
            SubmitButton = new Button();
            Western5 = new ComboBox();
            Western2 = new ComboBox();
            Western6 = new ComboBox();
            Western3 = new ComboBox();
            Western4 = new ComboBox();
            Western7 = new ComboBox();
            Western8 = new ComboBox();
            Western1 = new ComboBox();
            Eastern1 = new ComboBox();
            Eastern8 = new ComboBox();
            Eastern7 = new ComboBox();
            Eastern4 = new ComboBox();
            Eastern3 = new ComboBox();
            Eastern6 = new ComboBox();
            Eastern2 = new ComboBox();
            Eastern5 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            secondBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)secondBindingSource).BeginInit();
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
            NumberOfTeams.Items.AddRange(new object[] { 2, 4, 8, 16 });
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
            // Western5
            // 
            Western5.Enabled = false;
            Western5.FormattingEnabled = true;
            Western5.Location = new Point(364, 210);
            Western5.Name = "Western5";
            Western5.Size = new Size(151, 28);
            Western5.TabIndex = 6;
            Western5.Tag = "W5";
            Western5.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western5.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western2
            // 
            Western2.Enabled = false;
            Western2.FormattingEnabled = true;
            Western2.Location = new Point(364, 108);
            Western2.Name = "Western2";
            Western2.Size = new Size(151, 28);
            Western2.TabIndex = 7;
            Western2.Tag = "W2";
            Western2.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western2.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western6
            // 
            Western6.Enabled = false;
            Western6.FormattingEnabled = true;
            Western6.Location = new Point(364, 244);
            Western6.Name = "Western6";
            Western6.Size = new Size(151, 28);
            Western6.TabIndex = 8;
            Western6.Tag = "W6";
            Western6.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western6.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western3
            // 
            Western3.Enabled = false;
            Western3.FormattingEnabled = true;
            Western3.Location = new Point(364, 142);
            Western3.Name = "Western3";
            Western3.Size = new Size(151, 28);
            Western3.TabIndex = 9;
            Western3.Tag = "W3";
            Western3.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western3.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western4
            // 
            Western4.Enabled = false;
            Western4.FormattingEnabled = true;
            Western4.Location = new Point(364, 176);
            Western4.Name = "Western4";
            Western4.Size = new Size(151, 28);
            Western4.TabIndex = 10;
            Western4.Tag = "W4";
            Western4.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western4.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western7
            // 
            Western7.Enabled = false;
            Western7.FormattingEnabled = true;
            Western7.Location = new Point(364, 278);
            Western7.Name = "Western7";
            Western7.Size = new Size(151, 28);
            Western7.TabIndex = 11;
            Western7.Tag = "W7";
            Western7.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western7.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western8
            // 
            Western8.Enabled = false;
            Western8.FormattingEnabled = true;
            Western8.Location = new Point(364, 312);
            Western8.Name = "Western8";
            Western8.Size = new Size(151, 28);
            Western8.TabIndex = 12;
            Western8.Tag = "W8";
            Western8.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western8.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Western1
            // 
            Western1.Enabled = false;
            Western1.FormattingEnabled = true;
            Western1.Location = new Point(364, 74);
            Western1.Name = "Western1";
            Western1.Size = new Size(151, 28);
            Western1.TabIndex = 13;
            Western1.Tag = "W1";
            Western1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Western1.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern1
            // 
            Eastern1.Enabled = false;
            Eastern1.FormattingEnabled = true;
            Eastern1.Location = new Point(594, 74);
            Eastern1.Name = "Eastern1";
            Eastern1.Size = new Size(151, 28);
            Eastern1.TabIndex = 21;
            Eastern1.Tag = "E1";
            Eastern1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern1.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern8
            // 
            Eastern8.Enabled = false;
            Eastern8.FormattingEnabled = true;
            Eastern8.Location = new Point(594, 312);
            Eastern8.Name = "Eastern8";
            Eastern8.Size = new Size(151, 28);
            Eastern8.TabIndex = 20;
            Eastern8.Tag = "E8";
            Eastern8.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern8.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern7
            // 
            Eastern7.Enabled = false;
            Eastern7.FormattingEnabled = true;
            Eastern7.Location = new Point(594, 278);
            Eastern7.Name = "Eastern7";
            Eastern7.Size = new Size(151, 28);
            Eastern7.TabIndex = 19;
            Eastern7.Tag = "E7";
            Eastern7.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern7.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern4
            // 
            Eastern4.Enabled = false;
            Eastern4.FormattingEnabled = true;
            Eastern4.Location = new Point(594, 176);
            Eastern4.Name = "Eastern4";
            Eastern4.Size = new Size(151, 28);
            Eastern4.TabIndex = 18;
            Eastern4.Tag = "E4";
            Eastern4.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern4.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern3
            // 
            Eastern3.Enabled = false;
            Eastern3.FormattingEnabled = true;
            Eastern3.Location = new Point(594, 142);
            Eastern3.Name = "Eastern3";
            Eastern3.Size = new Size(151, 28);
            Eastern3.TabIndex = 17;
            Eastern3.Tag = "E3";
            Eastern3.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern3.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern6
            // 
            Eastern6.Enabled = false;
            Eastern6.FormattingEnabled = true;
            Eastern6.Location = new Point(594, 244);
            Eastern6.Name = "Eastern6";
            Eastern6.Size = new Size(151, 28);
            Eastern6.TabIndex = 16;
            Eastern6.Tag = "E6";
            Eastern6.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern6.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern2
            // 
            Eastern2.Enabled = false;
            Eastern2.FormattingEnabled = true;
            Eastern2.Location = new Point(594, 108);
            Eastern2.Name = "Eastern2";
            Eastern2.Size = new Size(151, 28);
            Eastern2.TabIndex = 15;
            Eastern2.Tag = "E2";
            Eastern2.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern2.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // Eastern5
            // 
            Eastern5.Enabled = false;
            Eastern5.FormattingEnabled = true;
            Eastern5.Location = new Point(594, 210);
            Eastern5.Name = "Eastern5";
            Eastern5.Size = new Size(151, 28);
            Eastern5.TabIndex = 14;
            Eastern5.Tag = "E5";
            Eastern5.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            Eastern5.VisibleChanged += ConferenceComboBox_VisibleChangedAsync;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(320, -5);
            label2.Name = "label2";
            label2.Size = new Size(230, 31);
            label2.TabIndex = 22;
            label2.Text = "Western Conference";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(556, -5);
            label3.Name = "label3";
            label3.Size = new Size(221, 31);
            label3.TabIndex = 23;
            label3.Text = "Eastern Conference";
            // 
            // secondBindingSource
            // 
            secondBindingSource.DataSource = typeof(Migrations.Second);
            // 
            // CreateTournamentBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo_teams;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Eastern1);
            Controls.Add(Eastern8);
            Controls.Add(Eastern7);
            Controls.Add(Eastern4);
            Controls.Add(Eastern3);
            Controls.Add(Eastern6);
            Controls.Add(Eastern2);
            Controls.Add(Eastern5);
            Controls.Add(Western1);
            Controls.Add(Western8);
            Controls.Add(Western7);
            Controls.Add(Western4);
            Controls.Add(Western3);
            Controls.Add(Western6);
            Controls.Add(Western2);
            Controls.Add(Western5);
            Controls.Add(SubmitButton);
            Controls.Add(NumberOfTeams);
            Controls.Add(label1);
            Controls.Add(CreateTournamentHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTournamentBox";
            Text = "CreateTournamentBox";
            Load += CreateTournamentBox_Load;
            ((System.ComponentModel.ISupportInitialize)secondBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTournamentHeading;
        private Label label1;
        private ComboBox NumberOfTeams;
        private Button SubmitButton;
        private ComboBox Western5;
        private ComboBox Western2;
        private ComboBox Western6;
        private ComboBox Western3;
        private ComboBox Western4;
        private ComboBox Western7;
        private ComboBox Western8;
        private ComboBox Western1;
        private ComboBox Eastern1;
        private ComboBox Eastern8;
        private ComboBox Eastern7;
        private ComboBox Eastern4;
        private ComboBox Eastern3;
        private ComboBox Eastern6;
        private ComboBox Eastern2;
        private ComboBox Eastern5;
        private Label label2;
        private Label label3;
        private BindingSource secondBindingSource;
    }
}