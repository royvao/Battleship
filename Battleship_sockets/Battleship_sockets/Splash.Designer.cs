namespace Battleship_sockets
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount.Font = new System.Drawing.Font("Space Age", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(0, 457);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(876, 47);
            this.lblCount.TabIndex = 2;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCopyright.Location = new System.Drawing.Point(602, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(274, 23);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "BattleshipSockets ©2023";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(99, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(659, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblPhrase);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 504);
            this.panel1.TabIndex = 6;
            // 
            // lblPhrase
            // 
            this.lblPhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPhrase.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhrase.Location = new System.Drawing.Point(0, 392);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(876, 65);
            this.lblPhrase.TabIndex = 6;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 503);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Splash_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblCount;
        private Label lblCopyright;
        private ProgressBar progressBar1;
        private Panel panel1;
        private Label lblPhrase;
    }
}