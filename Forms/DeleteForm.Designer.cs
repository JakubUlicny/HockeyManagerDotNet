namespace HockeyManager
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            label1 = new Label();
            DeleteTeamInputField = new TextBox();
            SubmitTeamNameButton = new Button();
            label2 = new Label();
            DeletePlayerInputField = new TextBox();
            SubmitPlayerNameButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 100);
            label1.TabIndex = 0;
            label1.Text = "If you want to delete team by its name, \r\nplease write it into this field\r\nand click on Submit Team Name button.\r\nIf you want to delete all teams,\r\nplease write \"all\".";
            label1.Click += label1_Click;
            // 
            // DeleteTeamInputField
            // 
            DeleteTeamInputField.Location = new Point(314, 32);
            DeleteTeamInputField.Name = "DeleteTeamInputField";
            DeleteTeamInputField.Size = new Size(162, 27);
            DeleteTeamInputField.TabIndex = 1;
            DeleteTeamInputField.TextAlign = HorizontalAlignment.Right;
            DeleteTeamInputField.TextChanged += DeleteTeamInputField_TextChanged;
            // 
            // SubmitTeamNameButton
            // 
            SubmitTeamNameButton.Enabled = false;
            SubmitTeamNameButton.Location = new Point(314, 65);
            SubmitTeamNameButton.Name = "SubmitTeamNameButton";
            SubmitTeamNameButton.Size = new Size(162, 29);
            SubmitTeamNameButton.TabIndex = 2;
            SubmitTeamNameButton.Text = "Submit Team Name";
            SubmitTeamNameButton.UseVisualStyleBackColor = true;
            SubmitTeamNameButton.Click += SubmitTeamNameButton_ClickAsync;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(278, 100);
            label2.TabIndex = 3;
            label2.Text = "If you want to delete player by his name,\r\nplease write the name into this field\r\nand click on Submit Player Name button.\r\nIf you want to delete all players,\r\nplease write \"all\".";
            label2.Click += label2_Click;
            // 
            // DeletePlayerInputField
            // 
            DeletePlayerInputField.Location = new Point(314, 182);
            DeletePlayerInputField.Name = "DeletePlayerInputField";
            DeletePlayerInputField.Size = new Size(162, 27);
            DeletePlayerInputField.TabIndex = 4;
            DeletePlayerInputField.TextAlign = HorizontalAlignment.Right;
            DeletePlayerInputField.TextChanged += DeletePlayerInputField_TextChanged;
            // 
            // SubmitPlayerNameButton
            // 
            SubmitPlayerNameButton.Enabled = false;
            SubmitPlayerNameButton.Location = new Point(314, 215);
            SubmitPlayerNameButton.Name = "SubmitPlayerNameButton";
            SubmitPlayerNameButton.Size = new Size(162, 29);
            SubmitPlayerNameButton.TabIndex = 5;
            SubmitPlayerNameButton.Text = "Submit Player Name";
            SubmitPlayerNameButton.UseVisualStyleBackColor = true;
            SubmitPlayerNameButton.Click += SubmitPlayerNameButton_ClickAsync;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 279);
            Controls.Add(SubmitPlayerNameButton);
            Controls.Add(DeletePlayerInputField);
            Controls.Add(label2);
            Controls.Add(SubmitTeamNameButton);
            Controls.Add(DeleteTeamInputField);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DeleteTeamInputField;
        private Button SubmitTeamNameButton;
        private Label label2;
        private TextBox DeletePlayerInputField;
        private Button SubmitPlayerNameButton;
    }
}