namespace escola_digital
{
    partial class user_control_verificacao_matricula
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
            this.pnl_verificacao_matricula = new System.Windows.Forms.Panel();
            this.dgv_matriculas = new System.Windows.Forms.DataGridView();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.ttb_procurar = new System.Windows.Forms.TextBox();
            this.lbl_para = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.ttb_apagar_idaluno = new System.Windows.Forms.TextBox();
            this.lbl_idaluno = new System.Windows.Forms.Label();
            this.pnl_verificacao_matricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_verificacao_matricula
            // 
            this.pnl_verificacao_matricula.Controls.Add(this.ttb_apagar_idaluno);
            this.pnl_verificacao_matricula.Controls.Add(this.lbl_idaluno);
            this.pnl_verificacao_matricula.Controls.Add(this.btn_delete);
            this.pnl_verificacao_matricula.Controls.Add(this.ttb_procurar);
            this.pnl_verificacao_matricula.Controls.Add(this.lbl_para);
            this.pnl_verificacao_matricula.Controls.Add(this.btn_procurar);
            this.pnl_verificacao_matricula.Controls.Add(this.btn_email);
            this.pnl_verificacao_matricula.Controls.Add(this.dgv_matriculas);
            this.pnl_verificacao_matricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_verificacao_matricula.Location = new System.Drawing.Point(0, 0);
            this.pnl_verificacao_matricula.Name = "pnl_verificacao_matricula";
            this.pnl_verificacao_matricula.Size = new System.Drawing.Size(950, 650);
            this.pnl_verificacao_matricula.TabIndex = 0;
            // 
            // dgv_matriculas
            // 
            this.dgv_matriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matriculas.Location = new System.Drawing.Point(43, 91);
            this.dgv_matriculas.Name = "dgv_matriculas";
            this.dgv_matriculas.Size = new System.Drawing.Size(858, 271);
            this.dgv_matriculas.TabIndex = 0;
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.Transparent;
            this.btn_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_email.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(45)))));
            this.btn_email.FlatAppearance.BorderSize = 3;
            this.btn_email.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_email.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_email.Location = new System.Drawing.Point(657, 494);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(119, 40);
            this.btn_email.TabIndex = 6;
            this.btn_email.Text = "E-mail";
            this.btn_email.UseVisualStyleBackColor = false;
            this.btn_email.Click += new System.EventHandler(this.Btn_email_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_procurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(45)))));
            this.btn_procurar.FlatAppearance.BorderSize = 3;
            this.btn_procurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procurar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procurar.Location = new System.Drawing.Point(782, 20);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(119, 40);
            this.btn_procurar.TabIndex = 7;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = false;
            this.btn_procurar.Click += new System.EventHandler(this.Btn_procurar_Click);
            // 
            // ttb_procurar
            // 
            this.ttb_procurar.BackColor = System.Drawing.Color.White;
            this.ttb_procurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_procurar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_procurar.ForeColor = System.Drawing.Color.Black;
            this.ttb_procurar.Location = new System.Drawing.Point(120, 28);
            this.ttb_procurar.Name = "ttb_procurar";
            this.ttb_procurar.Size = new System.Drawing.Size(656, 31);
            this.ttb_procurar.TabIndex = 57;
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_para.Location = new System.Drawing.Point(21, 30);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(93, 22);
            this.lbl_para.TabIndex = 58;
            this.lbl_para.Text = "Procurar:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(45)))));
            this.btn_delete.FlatAppearance.BorderSize = 3;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(292, 494);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 40);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.Text = "Apagar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // ttb_apagar_idaluno
            // 
            this.ttb_apagar_idaluno.BackColor = System.Drawing.Color.White;
            this.ttb_apagar_idaluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_apagar_idaluno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_apagar_idaluno.ForeColor = System.Drawing.Color.Black;
            this.ttb_apagar_idaluno.Location = new System.Drawing.Point(120, 502);
            this.ttb_apagar_idaluno.Name = "ttb_apagar_idaluno";
            this.ttb_apagar_idaluno.Size = new System.Drawing.Size(166, 31);
            this.ttb_apagar_idaluno.TabIndex = 60;
            // 
            // lbl_idaluno
            // 
            this.lbl_idaluno.AutoSize = true;
            this.lbl_idaluno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idaluno.Location = new System.Drawing.Point(26, 504);
            this.lbl_idaluno.Name = "lbl_idaluno";
            this.lbl_idaluno.Size = new System.Drawing.Size(88, 22);
            this.lbl_idaluno.TabIndex = 61;
            this.lbl_idaluno.Text = "IDAluno:";
            // 
            // user_control_verificacao_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_verificacao_matricula);
            this.Name = "user_control_verificacao_matricula";
            this.Size = new System.Drawing.Size(950, 650);
            this.Load += new System.EventHandler(this.User_control_verificacao_matricula_Load);
            this.pnl_verificacao_matricula.ResumeLayout(false);
            this.pnl_verificacao_matricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_verificacao_matricula;
        private System.Windows.Forms.DataGridView dgv_matriculas;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.TextBox ttb_procurar;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox ttb_apagar_idaluno;
        private System.Windows.Forms.Label lbl_idaluno;
    }
}
