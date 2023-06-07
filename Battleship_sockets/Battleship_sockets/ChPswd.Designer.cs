namespace Battleship_sockets
{
    partial class ChPswd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChPswd));
            this.BtnChngpwd = new System.Windows.Forms.Button();
            this.txtActualPwd = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.lblAp = new System.Windows.Forms.Label();
            this.lblNpw = new System.Windows.Forms.Label();
            this.lblNpw2 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnChngpwd
            // 
            this.BtnChngpwd.BackColor = System.Drawing.Color.Transparent;
            this.BtnChngpwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnChngpwd.BackgroundImage")));
            this.BtnChngpwd.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnChngpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChngpwd.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnChngpwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnChngpwd.Location = new System.Drawing.Point(43, 304);
            this.BtnChngpwd.Name = "BtnChngpwd";
            this.BtnChngpwd.Size = new System.Drawing.Size(151, 37);
            this.BtnChngpwd.TabIndex = 0;
            this.BtnChngpwd.Text = "APLICAR CAMBIOS";
            this.BtnChngpwd.UseVisualStyleBackColor = false;
            this.BtnChngpwd.Click += new System.EventHandler(this.BtnChngpwd_Click);
            this.BtnChngpwd.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // txtActualPwd
            // 
            this.txtActualPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualPwd.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtActualPwd.Location = new System.Drawing.Point(43, 100);
            this.txtActualPwd.Name = "txtActualPwd";
            this.txtActualPwd.PasswordChar = '*';
            this.txtActualPwd.Size = new System.Drawing.Size(225, 18);
            this.txtActualPwd.TabIndex = 1;
            this.txtActualPwd.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword.Location = new System.Drawing.Point(43, 168);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(225, 18);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword2.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword2.Location = new System.Drawing.Point(43, 246);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.PasswordChar = '*';
            this.txtNewPassword2.Size = new System.Drawing.Size(225, 18);
            this.txtNewPassword2.TabIndex = 3;
            this.txtNewPassword2.UseSystemPasswordChar = true;
            // 
            // lblAp
            // 
            this.lblAp.BackColor = System.Drawing.Color.Transparent;
            this.lblAp.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAp.ForeColor = System.Drawing.Color.Red;
            this.lblAp.Location = new System.Drawing.Point(281, 100);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(262, 23);
            this.lblAp.TabIndex = 4;
            this.lblAp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNpw
            // 
            this.lblNpw.BackColor = System.Drawing.Color.Transparent;
            this.lblNpw.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNpw.ForeColor = System.Drawing.Color.Red;
            this.lblNpw.Location = new System.Drawing.Point(274, 168);
            this.lblNpw.Name = "lblNpw";
            this.lblNpw.Size = new System.Drawing.Size(269, 23);
            this.lblNpw.TabIndex = 5;
            this.lblNpw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNpw2
            // 
            this.lblNpw2.BackColor = System.Drawing.Color.Transparent;
            this.lblNpw2.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNpw2.ForeColor = System.Drawing.Color.Red;
            this.lblNpw2.Location = new System.Drawing.Point(274, 246);
            this.lblNpw2.Name = "lblNpw2";
            this.lblNpw2.Size = new System.Drawing.Size(269, 26);
            this.lblNpw2.TabIndex = 6;
            this.lblNpw2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(43, 355);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(225, 99);
            this.lblErrorMessage.TabIndex = 7;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Space Age", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "CAMBIAR CONTRASEÑA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONTRASEÑA ACTUAL";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(43, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "NUEVA CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(43, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "REPETIR NUEVA CONTRASEÑA";
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.Transparent;
            this.GoBack.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GoBack.Image = ((System.Drawing.Image)(resources.GetObject("GoBack.Image")));
            this.GoBack.Location = new System.Drawing.Point(12, 487);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(31, 23);
            this.GoBack.TabIndex = 13;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            this.GoBack.MouseHover += new System.EventHandler(this.Btn_Enter);
            // 
            // ChPswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 519);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblNpw2);
            this.Controls.Add(this.lblNpw);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtActualPwd);
            this.Controls.Add(this.BtnChngpwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChPswd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnChngpwd;
        private TextBox txtActualPwd;
        private TextBox txtNewPassword;
        private TextBox txtNewPassword2;
        private Label lblAp;
        private Label lblNpw;
        private Label lblNpw2;
        private Label lblErrorMessage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label GoBack;
    }
}