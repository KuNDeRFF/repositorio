namespace escola_digital
{
    partial class user_control_email
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_user_control_email = new System.Windows.Forms.Panel();
            this.ttb_cc = new System.Windows.Forms.TextBox();
            this.lbl_cc = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.GroupBox();
            this.ckb_ssl = new System.Windows.Forms.CheckBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.ttb_smtp = new System.Windows.Forms.TextBox();
            this.lbl_smtp = new System.Windows.Forms.Label();
            this.ttb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.ttb_username = new System.Windows.Forms.TextBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.ttb_message = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.ttb_assunto = new System.Windows.Forms.TextBox();
            this.lbl_assunto = new System.Windows.Forms.Label();
            this.ttb_para = new System.Windows.Forms.TextBox();
            this.lbl_para = new System.Windows.Forms.Label();
            this.pnl_user_control_email.SuspendLayout();
            this.setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_user_control_email
            // 
            this.pnl_user_control_email.Controls.Add(this.ttb_cc);
            this.pnl_user_control_email.Controls.Add(this.lbl_cc);
            this.pnl_user_control_email.Controls.Add(this.setting);
            this.pnl_user_control_email.Controls.Add(this.ttb_message);
            this.pnl_user_control_email.Controls.Add(this.lbl_message);
            this.pnl_user_control_email.Controls.Add(this.ttb_assunto);
            this.pnl_user_control_email.Controls.Add(this.lbl_assunto);
            this.pnl_user_control_email.Controls.Add(this.ttb_para);
            this.pnl_user_control_email.Controls.Add(this.lbl_para);
            this.pnl_user_control_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_user_control_email.Location = new System.Drawing.Point(0, 0);
            this.pnl_user_control_email.Name = "pnl_user_control_email";
            this.pnl_user_control_email.Size = new System.Drawing.Size(950, 650);
            this.pnl_user_control_email.TabIndex = 0;
            // 
            // ttb_cc
            // 
            this.ttb_cc.BackColor = System.Drawing.Color.White;
            this.ttb_cc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_cc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_cc.ForeColor = System.Drawing.Color.Black;
            this.ttb_cc.Location = new System.Drawing.Point(191, 76);
            this.ttb_cc.Name = "ttb_cc";
            this.ttb_cc.Size = new System.Drawing.Size(724, 31);
            this.ttb_cc.TabIndex = 1;
            // 
            // lbl_cc
            // 
            this.lbl_cc.AutoSize = true;
            this.lbl_cc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cc.Location = new System.Drawing.Point(140, 78);
            this.lbl_cc.Name = "lbl_cc";
            this.lbl_cc.Size = new System.Drawing.Size(45, 22);
            this.lbl_cc.TabIndex = 102;
            this.lbl_cc.Text = "CC:";
            // 
            // setting
            // 
            this.setting.Controls.Add(this.ckb_ssl);
            this.setting.Controls.Add(this.btn_enviar);
            this.setting.Controls.Add(this.ttb_smtp);
            this.setting.Controls.Add(this.lbl_smtp);
            this.setting.Controls.Add(this.ttb_port);
            this.setting.Controls.Add(this.label2);
            this.setting.Controls.Add(this.ttb_password);
            this.setting.Controls.Add(this.lbl_password);
            this.setting.Controls.Add(this.ttb_username);
            this.setting.Controls.Add(this.lbl_user_name);
            this.setting.Location = new System.Drawing.Point(191, 398);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(724, 221);
            this.setting.TabIndex = 3;
            this.setting.TabStop = false;
            this.setting.Text = "Setting";
            // 
            // ckb_ssl
            // 
            this.ckb_ssl.AutoSize = true;
            this.ckb_ssl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_ssl.Location = new System.Drawing.Point(132, 171);
            this.ckb_ssl.Name = "ckb_ssl";
            this.ckb_ssl.Size = new System.Drawing.Size(56, 26);
            this.ckb_ssl.TabIndex = 1;
            this.ckb_ssl.Text = "SSL";
            this.ckb_ssl.UseVisualStyleBackColor = true;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Transparent;
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(45)))));
            this.btn_enviar.FlatAppearance.BorderSize = 3;
            this.btn_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enviar.Location = new System.Drawing.Point(520, 89);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(119, 40);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.Btn_enviar_Click);
            // 
            // ttb_smtp
            // 
            this.ttb_smtp.BackColor = System.Drawing.Color.White;
            this.ttb_smtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_smtp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_smtp.ForeColor = System.Drawing.Color.Black;
            this.ttb_smtp.Location = new System.Drawing.Point(132, 134);
            this.ttb_smtp.Name = "ttb_smtp";
            this.ttb_smtp.Size = new System.Drawing.Size(297, 31);
            this.ttb_smtp.TabIndex = 4;
            this.ttb_smtp.Text = "smtp.gmail.com";
            // 
            // lbl_smtp
            // 
            this.lbl_smtp.AutoSize = true;
            this.lbl_smtp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smtp.Location = new System.Drawing.Point(65, 136);
            this.lbl_smtp.Name = "lbl_smtp";
            this.lbl_smtp.Size = new System.Drawing.Size(61, 22);
            this.lbl_smtp.TabIndex = 1;
            this.lbl_smtp.Text = "Smtp:";
            // 
            // ttb_port
            // 
            this.ttb_port.BackColor = System.Drawing.Color.White;
            this.ttb_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_port.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_port.ForeColor = System.Drawing.Color.Black;
            this.ttb_port.Location = new System.Drawing.Point(132, 97);
            this.ttb_port.Name = "ttb_port";
            this.ttb_port.Size = new System.Drawing.Size(79, 31);
            this.ttb_port.TabIndex = 3;
            this.ttb_port.Text = "587";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // ttb_password
            // 
            this.ttb_password.BackColor = System.Drawing.Color.White;
            this.ttb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_password.ForeColor = System.Drawing.Color.Black;
            this.ttb_password.Location = new System.Drawing.Point(132, 60);
            this.ttb_password.Name = "ttb_password";
            this.ttb_password.Size = new System.Drawing.Size(257, 31);
            this.ttb_password.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(26, 62);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(100, 22);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            // 
            // ttb_username
            // 
            this.ttb_username.BackColor = System.Drawing.Color.White;
            this.ttb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_username.ForeColor = System.Drawing.Color.Black;
            this.ttb_username.Location = new System.Drawing.Point(132, 23);
            this.ttb_username.Name = "ttb_username";
            this.ttb_username.Size = new System.Drawing.Size(257, 31);
            this.ttb_username.TabIndex = 0;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.Location = new System.Drawing.Point(20, 25);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(106, 22);
            this.lbl_user_name.TabIndex = 1;
            this.lbl_user_name.Text = "Username:";
            // 
            // ttb_message
            // 
            this.ttb_message.BackColor = System.Drawing.Color.White;
            this.ttb_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_message.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_message.ForeColor = System.Drawing.Color.Black;
            this.ttb_message.Location = new System.Drawing.Point(191, 150);
            this.ttb_message.Multiline = true;
            this.ttb_message.Name = "ttb_message";
            this.ttb_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ttb_message.Size = new System.Drawing.Size(724, 217);
            this.ttb_message.TabIndex = 3;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(89, 152);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(96, 22);
            this.lbl_message.TabIndex = 60;
            this.lbl_message.Text = "Message:";
            // 
            // ttb_assunto
            // 
            this.ttb_assunto.BackColor = System.Drawing.Color.White;
            this.ttb_assunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_assunto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_assunto.ForeColor = System.Drawing.Color.Black;
            this.ttb_assunto.Location = new System.Drawing.Point(191, 113);
            this.ttb_assunto.Name = "ttb_assunto";
            this.ttb_assunto.Size = new System.Drawing.Size(724, 31);
            this.ttb_assunto.TabIndex = 2;
            // 
            // lbl_assunto
            // 
            this.lbl_assunto.AutoSize = true;
            this.lbl_assunto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assunto.Location = new System.Drawing.Point(98, 115);
            this.lbl_assunto.Name = "lbl_assunto";
            this.lbl_assunto.Size = new System.Drawing.Size(87, 22);
            this.lbl_assunto.TabIndex = 58;
            this.lbl_assunto.Text = "Assunto:";
            // 
            // ttb_para
            // 
            this.ttb_para.BackColor = System.Drawing.Color.White;
            this.ttb_para.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_para.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_para.ForeColor = System.Drawing.Color.Black;
            this.ttb_para.Location = new System.Drawing.Point(191, 39);
            this.ttb_para.Name = "ttb_para";
            this.ttb_para.Size = new System.Drawing.Size(724, 31);
            this.ttb_para.TabIndex = 0;
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_para.Location = new System.Drawing.Point(127, 41);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(58, 22);
            this.lbl_para.TabIndex = 56;
            this.lbl_para.Text = "Para:";
            // 
            // user_control_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_user_control_email);
            this.Name = "user_control_email";
            this.Size = new System.Drawing.Size(950, 650);
            this.pnl_user_control_email.ResumeLayout(false);
            this.pnl_user_control_email.PerformLayout();
            this.setting.ResumeLayout(false);
            this.setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_user_control_email;
        private System.Windows.Forms.TextBox ttb_assunto;
        private System.Windows.Forms.Label lbl_assunto;
        private System.Windows.Forms.TextBox ttb_para;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.TextBox ttb_message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.GroupBox setting;
        private System.Windows.Forms.TextBox ttb_smtp;
        private System.Windows.Forms.Label lbl_smtp;
        private System.Windows.Forms.TextBox ttb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox ttb_username;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.CheckBox ckb_ssl;
        private System.Windows.Forms.TextBox ttb_cc;
        private System.Windows.Forms.Label lbl_cc;
    }
}
