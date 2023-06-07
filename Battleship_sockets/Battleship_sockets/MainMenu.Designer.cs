namespace Battleship_sockets
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnServer = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Label();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Unmute = new System.Windows.Forms.Label();
            this.Mute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCliente.FlatAppearance.BorderSize = 2;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCliente.Location = new System.Drawing.Point(139, 265);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(204, 57);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Tag = "CLIENT";
            this.btnCliente.Text = "Modo Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Visible = false;
            this.btnCliente.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnCliente.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Space Age", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(727, 142);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "{SHIP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Location = new System.Drawing.Point(0, 427);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(274, 23);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "BattleshipSockets ©2023";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnServer.FlatAppearance.BorderSize = 2;
            this.btnServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServer.Location = new System.Drawing.Point(366, 265);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(204, 57);
            this.btnServer.TabIndex = 6;
            this.btnServer.Tag = "SERVER";
            this.btnServer.Text = "Modo Servidor";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Visible = false;
            this.btnServer.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnServer.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(710, 9);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(29, 23);
            this.Settings.TabIndex = 7;
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Btn_Play.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Play.FlatAppearance.BorderSize = 2;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Play.Location = new System.Drawing.Point(279, 205);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(168, 54);
            this.Btn_Play.TabIndex = 8;
            this.Btn_Play.Text = "JUGAR";
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.MouseHover += new System.EventHandler(this.BtnPlay_Enter);
            // 
            // Unmute
            // 
            this.Unmute.BackColor = System.Drawing.Color.Transparent;
            this.Unmute.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Unmute.Image = ((System.Drawing.Image)(resources.GetObject("Unmute.Image")));
            this.Unmute.Location = new System.Drawing.Point(685, 418);
            this.Unmute.Name = "Unmute";
            this.Unmute.Size = new System.Drawing.Size(54, 23);
            this.Unmute.TabIndex = 9;
            this.Unmute.Visible = false;
            this.Unmute.Click += new System.EventHandler(this.Unmute_Click);
            // 
            // Mute
            // 
            this.Mute.BackColor = System.Drawing.Color.Transparent;
            this.Mute.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.Location = new System.Drawing.Point(685, 418);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(54, 23);
            this.Mute.TabIndex = 10;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            this.Mute.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.Unmute);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCliente;
        private Label lblTitle;
        private Label lblCopyright;
        private ToolTip toolTip;
        private Button button1;
        private Button btnServer;
        private Label Settings;
        private Button Btn_Play;
        private Label Unmute;
        private Label Mute;
    }
}