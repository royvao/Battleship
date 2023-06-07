namespace Battleship_sockets
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblMyShips = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReady = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDestructor = new System.Windows.Forms.Button();
            this.BtnExplorer = new System.Windows.Forms.Button();
            this.BtnLightning = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel_Ocultar = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel_chat = new System.Windows.Forms.Panel();
            this.lstMensajes = new System.Windows.Forms.ListBox();
            this.Enviar = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.RBtnV = new System.Windows.Forms.RadioButton();
            this.RBtnH = new System.Windows.Forms.RadioButton();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.BtnAurora = new System.Windows.Forms.Button();
            this.panel_Ocultar.SuspendLayout();
            this.panel_chat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMyShips
            // 
            this.lblMyShips.BackColor = System.Drawing.Color.Transparent;
            this.lblMyShips.Font = new System.Drawing.Font("Space Age", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblMyShips.Location = new System.Drawing.Point(314, 185);
            this.lblMyShips.Name = "lblMyShips";
            this.lblMyShips.Size = new System.Drawing.Size(334, 35);
            this.lblMyShips.TabIndex = 2;
            this.lblMyShips.Text = "Mi panel";
            this.lblMyShips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpponent
            // 
            this.lblOpponent.BackColor = System.Drawing.Color.Transparent;
            this.lblOpponent.Font = new System.Drawing.Font("Space Age", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblOpponent.Location = new System.Drawing.Point(674, 185);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(334, 35);
            this.lblOpponent.TabIndex = 3;
            this.lblOpponent.Text = "Panel del enemigo";
            this.lblOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(314, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 322);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_ButtonClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(674, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 322);
            this.panel2.TabIndex = 5;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.Transparent;
            this.btnReady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReady.BackgroundImage")));
            this.btnReady.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReady.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReady.Location = new System.Drawing.Point(609, 604);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(104, 36);
            this.btnReady.TabIndex = 6;
            this.btnReady.Text = "¡Listo!";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.BtnReady_Click);
            this.btnReady.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tus naves";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDestructor
            // 
            this.BtnDestructor.BackColor = System.Drawing.Color.Transparent;
            this.BtnDestructor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDestructor.BackgroundImage")));
            this.BtnDestructor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnDestructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDestructor.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDestructor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDestructor.Location = new System.Drawing.Point(8, 246);
            this.BtnDestructor.Name = "BtnDestructor";
            this.BtnDestructor.Size = new System.Drawing.Size(282, 55);
            this.BtnDestructor.TabIndex = 8;
            this.BtnDestructor.Tag = "HORIZONTAL";
            this.BtnDestructor.Text = "Destructor Estelar Valiente";
            this.BtnDestructor.UseVisualStyleBackColor = false;
            this.BtnDestructor.Click += new System.EventHandler(this.Destructor_Click);
            this.BtnDestructor.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // BtnExplorer
            // 
            this.BtnExplorer.BackColor = System.Drawing.Color.Transparent;
            this.BtnExplorer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExplorer.BackgroundImage")));
            this.BtnExplorer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExplorer.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExplorer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExplorer.Location = new System.Drawing.Point(8, 307);
            this.BtnExplorer.Name = "BtnExplorer";
            this.BtnExplorer.Size = new System.Drawing.Size(282, 55);
            this.BtnExplorer.TabIndex = 10;
            this.BtnExplorer.Text = "Nave Exploradora Galáctica";
            this.BtnExplorer.UseVisualStyleBackColor = false;
            this.BtnExplorer.Click += new System.EventHandler(this.Explorer_Click);
            this.BtnExplorer.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // BtnLightning
            // 
            this.BtnLightning.BackColor = System.Drawing.Color.Transparent;
            this.BtnLightning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLightning.BackgroundImage")));
            this.BtnLightning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLightning.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnLightning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLightning.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLightning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLightning.Location = new System.Drawing.Point(8, 368);
            this.BtnLightning.Name = "BtnLightning";
            this.BtnLightning.Size = new System.Drawing.Size(282, 55);
            this.BtnLightning.TabIndex = 9;
            this.BtnLightning.Text = "Caza Planetas Relámpago";
            this.BtnLightning.UseVisualStyleBackColor = false;
            this.BtnLightning.Click += new System.EventHandler(this.Lightning_Click);
            this.BtnLightning.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(8, 594);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(289, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar tus naves";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // panel_Ocultar
            // 
            this.panel_Ocultar.BackColor = System.Drawing.Color.Transparent;
            this.panel_Ocultar.Controls.Add(this.btnConectar);
            this.panel_Ocultar.Controls.Add(this.lbl_Welcome);
            this.panel_Ocultar.Location = new System.Drawing.Point(8, 190);
            this.panel_Ocultar.Name = "panel_Ocultar";
            this.panel_Ocultar.Size = new System.Drawing.Size(1000, 455);
            this.panel_Ocultar.TabIndex = 22;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Transparent;
            this.btnConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConectar.BackgroundImage")));
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Space Age", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConectar.Location = new System.Drawing.Point(324, 161);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(290, 43);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "BUSCAR PARTIDA";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            this.btnConectar.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Welcome.Font = new System.Drawing.Font("Space Age", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Welcome.Location = new System.Drawing.Point(3, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(994, 232);
            this.lbl_Welcome.TabIndex = 24;
            this.lbl_Welcome.Tag = "OCULTAR";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBacktoMenu.BackgroundImage")));
            this.btnBacktoMenu.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnBacktoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacktoMenu.Font = new System.Drawing.Font("Space Age", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBacktoMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBacktoMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBacktoMenu.Image")));
            this.btnBacktoMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBacktoMenu.Location = new System.Drawing.Point(8, 651);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(133, 46);
            this.btnBacktoMenu.TabIndex = 23;
            this.btnBacktoMenu.Text = "MENÚ";
            this.btnBacktoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.BtnBackToMenu_Click);
            this.btnBacktoMenu.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInfo.Font = new System.Drawing.Font("Space Age", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo.Location = new System.Drawing.Point(8, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(960, 152);
            this.lblInfo.TabIndex = 23;
            this.lblInfo.Tag = "OCULTAR";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_chat
            // 
            this.panel_chat.BackColor = System.Drawing.Color.Transparent;
            this.panel_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_chat.Controls.Add(this.lstMensajes);
            this.panel_chat.Controls.Add(this.Enviar);
            this.panel_chat.Controls.Add(this.lblEnemy);
            this.panel_chat.Controls.Add(this.txtMensaje);
            this.panel_chat.Location = new System.Drawing.Point(1014, 9);
            this.panel_chat.Name = "panel_chat";
            this.panel_chat.Size = new System.Drawing.Size(269, 700);
            this.panel_chat.TabIndex = 23;
            // 
            // lstMensajes
            // 
            this.lstMensajes.BackColor = System.Drawing.Color.Gray;
            this.lstMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMensajes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.ItemHeight = 15;
            this.lstMensajes.Location = new System.Drawing.Point(11, 45);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(247, 585);
            this.lstMensajes.TabIndex = 25;
            this.lstMensajes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstMensajes_DrawItem);
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.Color.Transparent;
            this.Enviar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enviar.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Enviar.Image = ((System.Drawing.Image)(resources.GetObject("Enviar.Image")));
            this.Enviar.Location = new System.Drawing.Point(216, 642);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(42, 46);
            this.Enviar.TabIndex = 26;
            this.Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // lblEnemy
            // 
            this.lblEnemy.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnemy.Font = new System.Drawing.Font("Space Age", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnemy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnemy.Location = new System.Drawing.Point(11, 12);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(247, 24);
            this.lblEnemy.TabIndex = 24;
            this.lblEnemy.Text = "CHAT";
            this.lblEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensaje.Location = new System.Drawing.Point(11, 642);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(199, 46);
            this.txtMensaje.TabIndex = 24;
            this.txtMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMensaje_KeyDown);
            // 
            // RBtnV
            // 
            this.RBtnV.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RBtnV.Cursor = System.Windows.Forms.Cursors.Cross;
            this.RBtnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBtnV.Font = new System.Drawing.Font("Space Age", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBtnV.Location = new System.Drawing.Point(159, 536);
            this.RBtnV.Name = "RBtnV";
            this.RBtnV.Size = new System.Drawing.Size(138, 32);
            this.RBtnV.TabIndex = 30;
            this.RBtnV.TabStop = true;
            this.RBtnV.Text = "Vertical";
            this.RBtnV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnV.UseVisualStyleBackColor = false;
            this.RBtnV.CheckedChanged += new System.EventHandler(this.RBtnV_CheckedChanged);
            this.RBtnV.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // RBtnH
            // 
            this.RBtnH.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RBtnH.Cursor = System.Windows.Forms.Cursors.Cross;
            this.RBtnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBtnH.Font = new System.Drawing.Font("Space Age", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBtnH.Location = new System.Drawing.Point(8, 536);
            this.RBtnH.Name = "RBtnH";
            this.RBtnH.Size = new System.Drawing.Size(138, 32);
            this.RBtnH.TabIndex = 29;
            this.RBtnH.TabStop = true;
            this.RBtnH.Text = "Horizontal";
            this.RBtnH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnH.UseVisualStyleBackColor = false;
            this.RBtnH.CheckedChanged += new System.EventHandler(this.RBtnH_CheckedChanged);
            this.RBtnH.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCopyright.Location = new System.Drawing.Point(0, 700);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(269, 23);
            this.lblCopyright.TabIndex = 25;
            this.lblCopyright.Text = "BattleshipSockets ©2023";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAurora
            // 
            this.BtnAurora.BackColor = System.Drawing.Color.Transparent;
            this.BtnAurora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAurora.BackgroundImage")));
            this.BtnAurora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAurora.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnAurora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAurora.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAurora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAurora.Location = new System.Drawing.Point(8, 429);
            this.BtnAurora.Name = "BtnAurora";
            this.BtnAurora.Size = new System.Drawing.Size(282, 55);
            this.BtnAurora.TabIndex = 31;
            this.BtnAurora.Text = "Aurora Celestial Vengadora";
            this.BtnAurora.UseVisualStyleBackColor = false;
            this.BtnAurora.Click += new System.EventHandler(this.Aurora_Click);
            this.BtnAurora.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 721);
            this.Controls.Add(this.panel_Ocultar);
            this.Controls.Add(this.BtnAurora);
            this.Controls.Add(this.BtnLightning);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.RBtnV);
            this.Controls.Add(this.RBtnH);
            this.Controls.Add(this.panel_chat);
            this.Controls.Add(this.BtnDestructor);
            this.Controls.Add(this.btnBacktoMenu);
            this.Controls.Add(this.BtnExplorer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblMyShips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUNDIR LA FLOTA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.panel_Ocultar.ResumeLayout(false);
            this.panel_chat.ResumeLayout(false);
            this.panel_chat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblMyShips;
        private Label lblOpponent;
        private Panel panel1;
        private Panel panel2;
        private Button btnReady;
        private Label label1;
        private Button BtnDestructor;
        private Button BtnExplorer;
        private Button BtnLightning;
        private Button btnClear;
        public Panel panel_Ocultar;
        public Label lblInfo;
        public Button btnBacktoMenu;
        public Panel panel_chat;
        private Label lblEnemy;
        public TextBox txtMensaje;
        public Label lbl_Welcome;
        private Button btnConectar;
        public Label Enviar;
        public ListBox lstMensajes;
        private RadioButton RBtnV;
        private RadioButton RBtnH;
        private Label lblCopyright;
        private Button BtnAurora;
    }
}