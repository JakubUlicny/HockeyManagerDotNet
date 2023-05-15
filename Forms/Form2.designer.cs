using System.Threading.Tasks;

namespace HockeyManager
{
    partial class Form2
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
            button1 = new Button();
            addPlayers = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 539);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(180, 81);
            button1.TabIndex = 0;
            button1.Text = "Add players";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addPlayers
            // 
            addPlayers.FileName = "addPlayers";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.NHL_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 638);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Create Tournament";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog addPlayers;
    }
}