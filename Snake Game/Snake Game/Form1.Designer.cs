namespace Snake_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LbScreen = new Panel();
            LbScore = new Label();
            Frame = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            startToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LbScreen
            // 
            LbScreen.BorderStyle = BorderStyle.Fixed3D;
            LbScreen.Location = new Point(7, 56);
            LbScreen.Name = "LbScreen";
            LbScreen.Size = new Size(428, 433);
            LbScreen.TabIndex = 0;
            LbScreen.Paint += panel1_Paint;
            // 
            // LbScore
            // 
            LbScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbScore.Location = new Point(7, 24);
            LbScore.Name = "LbScore";
            LbScore.Size = new Size(428, 29);
            LbScore.TabIndex = 0;
            LbScore.Text = "SCORE: 0";
            LbScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Frame
            // 
            Frame.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { startToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.BackColor = SystemColors.Control;
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(76, 20);
            startToolStripMenuItem.Text = "Start game";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 498);
            Controls.Add(LbScore);
            Controls.Add(LbScreen);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake Game";
            KeyDown += Form1_KeyPress;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LbScreen;
        private Label LbScore;
        private System.Windows.Forms.Timer Frame;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
