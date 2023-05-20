namespace HockeyManager.Forms
{
    partial class ConferenceFinals
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
            WesternFirst = new Label();
            WesternSecond = new Label();
            EScore1 = new Label();
            EScore2 = new Label();
            WScore2 = new Label();
            WScore1 = new Label();
            EasternSecond = new Label();
            EasternFirst = new Label();
            NextRound = new Button();
            SuspendLayout();
            // 
            // WesternFirst
            // 
            WesternFirst.AutoSize = true;
            WesternFirst.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            WesternFirst.ForeColor = Color.AliceBlue;
            WesternFirst.Location = new Point(12, 135);
            WesternFirst.Name = "WesternFirst";
            WesternFirst.Size = new Size(313, 41);
            WesternFirst.TabIndex = 2;
            WesternFirst.Tag = "WT1";
            WesternFirst.Text = "Vegas Golden Knights";
            // 
            // WesternSecond
            // 
            WesternSecond.AutoSize = true;
            WesternSecond.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            WesternSecond.ForeColor = Color.AliceBlue;
            WesternSecond.Location = new Point(502, 135);
            WesternSecond.Name = "WesternSecond";
            WesternSecond.Size = new Size(100, 41);
            WesternSecond.TabIndex = 3;
            WesternSecond.Tag = "WT2";
            WesternSecond.Text = "label2";
            // 
            // EScore1
            // 
            EScore1.AutoSize = true;
            EScore1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            EScore1.ForeColor = Color.AliceBlue;
            EScore1.Location = new Point(359, 304);
            EScore1.Name = "EScore1";
            EScore1.Size = new Size(35, 41);
            EScore1.TabIndex = 42;
            EScore1.Tag = "E1Sc";
            EScore1.Text = "0";
            EScore1.Click += Score_Click;
            // 
            // EScore2
            // 
            EScore2.AutoSize = true;
            EScore2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            EScore2.ForeColor = Color.AliceBlue;
            EScore2.Location = new Point(461, 304);
            EScore2.Name = "EScore2";
            EScore2.Size = new Size(35, 41);
            EScore2.TabIndex = 41;
            EScore2.Tag = "E2Sc";
            EScore2.Text = "0";
            EScore2.Click += Score_Click;
            // 
            // WScore2
            // 
            WScore2.AutoSize = true;
            WScore2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            WScore2.ForeColor = Color.AliceBlue;
            WScore2.Location = new Point(461, 135);
            WScore2.Name = "WScore2";
            WScore2.Size = new Size(35, 41);
            WScore2.TabIndex = 40;
            WScore2.Tag = "W2Sc";
            WScore2.Text = "0";
            WScore2.Click += Score_Click;
            // 
            // WScore1
            // 
            WScore1.AutoSize = true;
            WScore1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            WScore1.ForeColor = Color.AliceBlue;
            WScore1.Location = new Point(359, 135);
            WScore1.Name = "WScore1";
            WScore1.Size = new Size(35, 41);
            WScore1.TabIndex = 39;
            WScore1.Tag = "W1Sc";
            WScore1.Text = "0";
            WScore1.Click += Score_Click;
            // 
            // EasternSecond
            // 
            EasternSecond.AutoSize = true;
            EasternSecond.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            EasternSecond.ForeColor = Color.AliceBlue;
            EasternSecond.Location = new Point(502, 304);
            EasternSecond.Name = "EasternSecond";
            EasternSecond.Size = new Size(112, 41);
            EasternSecond.TabIndex = 38;
            EasternSecond.Tag = "ET2";
            EasternSecond.Text = "label15";
            // 
            // EasternFirst
            // 
            EasternFirst.AutoSize = true;
            EasternFirst.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            EasternFirst.ForeColor = Color.AliceBlue;
            EasternFirst.Location = new Point(40, 304);
            EasternFirst.Name = "EasternFirst";
            EasternFirst.Size = new Size(113, 41);
            EasternFirst.TabIndex = 37;
            EasternFirst.Tag = "ET1";
            EasternFirst.Text = "label16";
            // 
            // NextRound
            // 
            NextRound.Enabled = false;
            NextRound.Location = new Point(658, 215);
            NextRound.Name = "NextRound";
            NextRound.Size = new Size(130, 32);
            NextRound.TabIndex = 43;
            NextRound.Text = "Next Round";
            NextRound.UseVisualStyleBackColor = true;
            NextRound.Click += NextRound_Click;
            // 
            // ConferenceFinals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(NextRound);
            Controls.Add(EScore1);
            Controls.Add(EScore2);
            Controls.Add(WScore2);
            Controls.Add(WScore1);
            Controls.Add(EasternSecond);
            Controls.Add(EasternFirst);
            Controls.Add(WesternSecond);
            Controls.Add(WesternFirst);
            Name = "ConferenceFinals";
            Text = "ConferenceFinals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WesternFirst;
        private Label WesternSecond;
        private Label EScore1;
        private Label EScore2;
        private Label WScore2;
        private Label WScore1;
        private Label EasternSecond;
        private Label EasternFirst;
        private Button NextRound;
    }
}