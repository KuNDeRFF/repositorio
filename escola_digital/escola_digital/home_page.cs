using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace escola_digital
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //
        //sempre que pressionar o botão e o "pnl_menu_vertical" estiver com uma largura de 250 ele vai ficar com 75, se estiver com 75 de largura vai ficar com 250.
        //
        private void Btn_menu_slide_Click(object sender, EventArgs e)
        {
            if (pnl_menu_vertical_num_1.Width == 250)
            {
                pnl_menu_vertical_num_1.Width = 70;
            }
            else
            {
                pnl_menu_vertical_num_1.Width = 250;
            }
        }
        

        //
        //codigo que permite o programa encerrar quando pressionamos o botão "btn-close".
        //
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void Btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_encolher_janela.Visible = true;
            btn_max.Visible = false;
        }

        private void Btn_encolher_janela_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_encolher_janela.Visible = false;
            btn_max.Visible = true;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Pnl_barra_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_registar_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(user_control_escolher_registo.Instance))
            {
                pnl_container.Controls.Add(user_control_escolher_registo.Instance);
                user_control_escolher_registo.Instance.Dock = DockStyle.Fill;
                user_control_escolher_registo.Instance.BringToFront();
            }
            else
            {
                user_control_escolher_registo.Instance.BringToFront();
            }         
        }

        private void Btn_login_Resize(object sender, EventArgs e)
        {
            this.pnl_container.Controls[0].Top = this.pnl_container.Bounds.Height / 2 - this.pnl_container.Controls[0].Bounds.Height / 2;
            this.pnl_container.Controls[0].Left = this.pnl_container.Bounds.Width / 2 - this.pnl_container.Controls[0].Bounds.Width / 2;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(user_control_login.Instance))
            {
                user_control_login.Instance.OnBtnVisi += new EventHandler(Login_OnBtnVisi);
                user_control_login.Instance.BtnVisibi += new EventHandler(Login_BtnVisibi);
                pnl_container.Controls.Add(user_control_login.Instance);
                user_control_login.Instance.Dock = DockStyle.Fill;
                user_control_login.Instance.BringToFront();
            }
            else
            {
                user_control_login.Instance.BringToFront();
            }
        }

        private void Login_BtnVisibi(object sender, EventArgs e)
        {
            btn_login.Visible = false;
            btn_registar.Visible = false;
            btn_matricula.Visible = false;
            btn_email.Visible = false;
            btn_verificacao.Visible = true;
        }

        private void Login_OnBtnVisi(object sender, EventArgs e)
        {
            btn_login.Visible = false;
            btn_registar.Visible = false;
            btn_matricula.Visible = true;
            btn_email.Visible = true;
            btn_verificacao.Visible = false;
        }

        private void Btn_matricula_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(user_control_matricula_aluno.Instance))
            {
                pnl_container.Controls.Add(user_control_matricula_aluno.Instance);
                user_control_matricula_aluno.Instance.Dock = DockStyle.Fill;
                user_control_matricula_aluno.Instance.BringToFront();
            }
            else
            {
                user_control_matricula_aluno.Instance.BringToFront();
            }
        }

        private void Btn_verificacao_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(user_control_verificacao_matricula.Instance))
            {
                pnl_container.Controls.Add(user_control_verificacao_matricula.Instance);
                user_control_verificacao_matricula.Instance.Dock = DockStyle.Fill;
                user_control_verificacao_matricula.Instance.BringToFront();
            }
            else
            {
                user_control_verificacao_matricula.Instance.BringToFront();
            }
        }

        private void Btn_email_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(user_control_email.Instance))
            {
                pnl_container.Controls.Add(user_control_email.Instance);
                user_control_email.Instance.Dock = DockStyle.Fill;
                user_control_email.Instance.BringToFront();
            }
            else
            {
                user_control_email.Instance.BringToFront();
            }
        }
    }       
}
