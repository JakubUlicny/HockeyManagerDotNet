namespace HockeyManager.Forms
{
    partial class CupFinal
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
            easternTeam = new Label();
            VS = new Label();
            westernScore = new Label();
            easternScore = new Label();
            westernTeam = new Label();
            StatsButton = new Button();
            SuspendLayout();
            // 
            // easternTeam
            // 
            easternTeam.AutoSize = true;
            easternTeam.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            easternTeam.ForeColor = Color.AliceBlue;
            easternTeam.ImageAlign = ContentAlignment.TopCenter;
            easternTeam.Location = new Point(281, 58);
            easternTeam.Name = "easternTeam";
            easternTeam.Size = new Size(165, 60);
            easternTeam.TabIndex = 0;
            easternTeam.Tag = "E2";
            easternTeam.Text = "Team1";
            easternTeam.TextAlign = ContentAlignment.TopCenter;
            // 
            // VS
            // 
            VS.AutoSize = true;
            VS.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            VS.ForeColor = Color.AliceBlue;
            VS.Location = new Point(365, 174);
            VS.Name = "VS";
            VS.Size = new Size(78, 60);
            VS.TabIndex = 1;
            VS.Tag = "0";
            VS.Text = "VS";
            // 
            // westernScore
            // 
            westernScore.AutoSize = true;
            westernScore.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            westernScore.ForeColor = Color.AliceBlue;
            westernScore.Location = new Point(477, 234);
            westernScore.Name = "westernScore";
            westernScore.Size = new Size(50, 60);
            westernScore.TabIndex = 2;
            westernScore.Tag = "1";
            westernScore.Text = "0";
            westernScore.Click += westernScore_Click;
            // 
            // easternScore
            // 
            easternScore.AutoSize = true;
            easternScore.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            easternScore.ForeColor = Color.AliceBlue;
            easternScore.Location = new Point(281, 118);
            easternScore.Name = "easternScore";
            easternScore.Size = new Size(50, 60);
            easternScore.TabIndex = 3;
            easternScore.Tag = "1";
            easternScore.Text = "0";
            easternScore.TextAlign = ContentAlignment.TopCenter;
            easternScore.Click += EasternScore_Click;
            // 
            // westernTeam
            // 
            westernTeam.AutoSize = true;
            westernTeam.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            westernTeam.ForeColor = Color.AliceBlue;
            westernTeam.Location = new Point(362, 315);
            westernTeam.Name = "westernTeam";
            westernTeam.Size = new Size(165, 60);
            westernTeam.TabIndex = 4;
            westernTeam.Tag = "W2";
            westernTeam.Text = "Team2";
            // 
            // StatsButton
            // 
            StatsButton.Enabled = false;
            StatsButton.Location = new Point(45, 369);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(170, 57);
            StatsButton.TabIndex = 5;
            StatsButton.Text = "Player Stats";
            StatsButton.UseVisualStyleBackColor = true;
            StatsButton.Click += button1_Click;
            // 
            // CupFinal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(StatsButton);
            Controls.Add(westernTeam);
            Controls.Add(easternScore);
            Controls.Add(westernScore);
            Controls.Add(VS);
            Controls.Add(easternTeam);
            Name = "CupFinal";
            Text = "CupFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label easternTeam;
        private Label VS;
        private Label westernScore;
        private Label easternScore;
        private Label westernTeam;
        private Button StatsButton;
    }
}