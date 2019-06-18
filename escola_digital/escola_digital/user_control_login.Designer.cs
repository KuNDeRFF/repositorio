namespace escola_digital
{
    partial class user_control_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_control_login));
            this.pnl_usercon_login = new System.Windows.Forms.Panel();
            this.btn_ver_pass = new System.Windows.Forms.PictureBox();
            this.btn_nao_ver_pass = new System.Windows.Forms.PictureBox();
            this.ttb_usercon_palavra_passe = new System.Windows.Forms.TextBox();
            this.ttb_usercon_email = new System.Windows.Forms.TextBox();
            this.btn_usercon_entrar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnl_usercon_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nao_ver_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_usercon_login
            // 
            this.pnl_usercon_login.Controls.Add(this.btn_ver_pass);
            this.pnl_usercon_login.Controls.Add(this.btn_nao_ver_pass);
            this.pnl_usercon_login.Controls.Add(this.ttb_usercon_palavra_passe);
            this.pnl_usercon_login.Controls.Add(this.ttb_usercon_email);
            this.pnl_usercon_login.Controls.Add(this.btn_usercon_entrar);
            this.pnl_usercon_login.Controls.Add(this.shapeContainer1);
            this.pnl_usercon_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_usercon_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_usercon_login.Name = "pnl_usercon_login";
            this.pnl_usercon_login.Size = new System.Drawing.Size(950, 650);
            this.pnl_usercon_login.TabIndex = 0;
            // 
            // btn_ver_pass
            // 
            this.btn_ver_pass.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver_pass.Image")));
            this.btn_ver_pass.Location = new System.Drawing.Point(643, 271);
            this.btn_ver_pass.Name = "btn_ver_pass";
            this.btn_ver_pass.Size = new System.Drawing.Size(30, 30);
            this.btn_ver_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ver_pass.TabIndex = 52;
            this.btn_ver_pass.TabStop = false;
            this.btn_ver_pass.Click += new System.EventHandler(this.Btn_ver_pass_Click);
            // 
            // btn_nao_ver_pass
            // 
            this.btn_nao_ver_pass.Image = ((System.Drawing.Image)(resources.GetObject("btn_nao_ver_pass.Image")));
            this.btn_nao_ver_pass.Location = new System.Drawing.Point(643, 270);
            this.btn_nao_ver_pass.Name = "btn_nao_ver_pass";
            this.btn_nao_ver_pass.Size = new System.Drawing.Size(30, 30);
            this.btn_nao_ver_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_nao_ver_pass.TabIndex = 53;
            this.btn_nao_ver_pass.TabStop = false;
            this.btn_nao_ver_pass.Click += new System.EventHandler(this.Btn_nao_ver_pass_Click);
            // 
            // ttb_usercon_palavra_passe
            // 
            this.ttb_usercon_palavra_passe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ttb_usercon_palavra_passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttb_usercon_palavra_passe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_usercon_palavra_passe.ForeColor = System.Drawing.Color.DimGray;
            this.ttb_usercon_palavra_passe.Location = new System.Drawing.Point(286, 280);
            this.ttb_usercon_palavra_passe.Name = "ttb_usercon_palavra_passe";
            this.ttb_usercon_palavra_passe.Size = new System.Drawing.Size(351, 20);
            this.ttb_usercon_palavra_passe.TabIndex = 17;
            this.ttb_usercon_palavra_passe.Text = "Palavra-passe";
            this.ttb_usercon_palavra_passe.Enter += new System.EventHandler(this.Ttb_usercon_palavra_passe_Enter);
            this.ttb_usercon_palavra_passe.Leave += new System.EventHandler(this.Ttb_usercon_palavra_passe_Leave);
            // 
            // ttb_usercon_email
            // 
            this.ttb_usercon_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ttb_usercon_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttb_usercon_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_usercon_email.ForeColor = System.Drawing.Color.DimGray;
            this.ttb_usercon_email.Location = new System.Drawing.Point(288, 196);
            this.ttb_usercon_email.Name = "ttb_usercon_email";
            this.ttb_usercon_email.Size = new System.Drawing.Size(351, 20);
            this.ttb_usercon_email.TabIndex = 16;
            this.ttb_usercon_email.Text = "E-mail";
            this.ttb_usercon_email.Enter += new System.EventHandler(this.Ttb_usercon_email_Enter);
            this.ttb_usercon_email.Leave += new System.EventHandler(this.Ttb_usercon_email_Leave);
            // 
            // btn_usercon_entrar
            // 
            this.btn_usercon_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_usercon_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usercon_entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(45)))));
            this.btn_usercon_entrar.FlatAppearance.BorderSize = 3;
            this.btn_usercon_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_usercon_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usercon_entrar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usercon_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usercon_entrar.Location = new System.Drawing.Point(328, 405);
            this.btn_usercon_entrar.Name = "btn_usercon_entrar";
            this.btn_usercon_entrar.Size = new System.Drawing.Size(250, 50);
            this.btn_usercon_entrar.TabIndex = 15;
            this.btn_usercon_entrar.Text = "Entrar";
            this.btn_usercon_entrar.UseVisualStyleBackColor = false;
            this.btn_usercon_entrar.Click += new System.EventHandler(this.Btn_usercon_entrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(950, 650);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 287;
            this.lineShape2.X2 = 631;
            this.lineShape2.Y1 = 300;
            this.lineShape2.Y2 = 300;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 287;
            this.lineShape1.X2 = 631;
            this.lineShape1.Y1 = 216;
            this.lineShape1.Y2 = 216;
            // 
            // user_control_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_usercon_login);
            this.Name = "user_control_login";
            this.Size = new System.Drawing.Size(950, 650);
            this.pnl_usercon_login.ResumeLayout(false);
            this.pnl_usercon_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nao_ver_pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_usercon_login;
        private System.Windows.Forms.TextBox ttb_usercon_palavra_passe;
        private System.Windows.Forms.TextBox ttb_usercon_email;
        private System.Windows.Forms.Button btn_usercon_entrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox btn_ver_pass;
        private System.Windows.Forms.PictureBox btn_nao_ver_pass;
    }
}
