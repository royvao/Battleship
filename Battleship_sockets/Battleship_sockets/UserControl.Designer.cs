namespace Battleship_sockets
{
    partial class UserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl));
            this.button1 = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.pswdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Space Age", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(196, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // userTxt
            // 
            this.userTxt.BackColor = System.Drawing.SystemColors.Window;
            this.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTxt.Font = new System.Drawing.Font("Space Age", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userTxt.Location = new System.Drawing.Point(154, 101);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(183, 12);
            this.userTxt.TabIndex = 1;
            // 
            // pswdTxt
            // 
            this.pswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pswdTxt.Font = new System.Drawing.Font("Space Age", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswdTxt.Location = new System.Drawing.Point(154, 158);
            this.pswdTxt.Name = "pswdTxt";
            this.pswdTxt.PasswordChar = '*';
            this.pswdTxt.Size = new System.Drawing.Size(183, 12);
            this.pswdTxt.TabIndex = 2;
            this.pswdTxt.UseSystemPasswordChar = true;
            this.pswdTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PswdTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(154, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Space Age", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(154, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Space Age", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iniciar sesión";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblErrorMessage.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessage.Location = new System.Drawing.Point(0, 336);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(480, 37);
            this.LblErrorMessage.TabIndex = 6;
            this.LblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label4.Font = new System.Drawing.Font("Space Age", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(154, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "No tengo cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            this.label4.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Location = new System.Drawing.Point(0, 350);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(274, 23);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "BattleshipSockets ©2023";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 373);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pswdTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox userTxt;
        private TextBox pswdTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblErrorMessage;
        private Label label4;
        private Label lblCopyright;
    }
}
