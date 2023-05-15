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
            CreateTournamentHeading = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // CreateTournamentHeading
            // 
            CreateTournamentHeading.Anchor = AnchorStyles.Top;
            CreateTournamentHeading.AutoSize = true;
            CreateTournamentHeading.BackColor = SystemColors.ButtonFace;
            CreateTournamentHeading.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentHeading.ForeColor = Color.Navy;
            CreateTournamentHeading.Location = new Point(250, 152);
            CreateTournamentHeading.Name = "CreateTournamentHeading";
            CreateTournamentHeading.Size = new Size(316, 38);
            CreateTournamentHeading.TabIndex = 0;
            CreateTournamentHeading.Text = "Create Your Tournament";
            CreateTournamentHeading.TextAlign = ContentAlignment.TopCenter;
            CreateTournamentHeading.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(66, 354);
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(47, 310);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 2;
            label1.Text = "Number Of Teams";
            // 
            // CreateTournamentBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.addPlayers;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(CreateTournamentHeading);
            Name = "CreateTournamentBox";
            Text = "CreateTournamentBox";
            Load += CreateTournamentBox_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTournamentHeading;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}