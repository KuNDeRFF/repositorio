using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace escola_digital
{
    public partial class user_control_login : UserControl
    {
        
        MySqlConnection DataBase = new MySqlConnection("Server=localhost;Database=dt_escoladigital;Uid=root;Pwd=123456;");
        MySqlCommand cmd_funcionario = new MySqlCommand();
        MySqlCommand cmd_aluno = new MySqlCommand();

        [Category("_Visibilidade dos botões_")]
        [Description("Dispara quando o botão entrar é precionado")]
        public event EventHandler OnBtnVisi;

        [Category("_Visibilidade dos botões_")]
        [Description("Dispara quando o botão entrar é precionado")]
        public event EventHandler BtnVisibi;
        
        private static user_control_login _instance;

        public static user_control_login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_login();
                return _instance;
            }
        }

        public user_control_login()
        {
            InitializeComponent();
        }

        private void Ttb_usercon_email_Enter(object sender, EventArgs e)
        {
            if (ttb_usercon_email.Text == "E-mail")
            {
                ttb_usercon_email.Text = "";
                ttb_usercon_email.ForeColor = Color.Black;
            }
        }

        private void Ttb_usercon_email_Leave(object sender, EventArgs e)
        {
            if (ttb_usercon_email.Text == "")
            {
                ttb_usercon_email.Text = "E-mail";
                ttb_usercon_email.ForeColor = Color.DimGray;
            }
        }

        private void Ttb_usercon_palavra_passe_Enter(object sender, EventArgs e)
        {
            if (ttb_usercon_palavra_passe.Text == "Palavra-passe")
            {
                ttb_usercon_palavra_passe.Text = "";
                ttb_usercon_palavra_passe.ForeColor = Color.Black;
                ttb_usercon_palavra_passe.UseSystemPasswordChar = true;
            }
        }

        private void Ttb_usercon_palavra_passe_Leave(object sender, EventArgs e)
        {
            if (ttb_usercon_palavra_passe.Text == "")
            {
                ttb_usercon_palavra_passe.Text = "Palavra-passe";
                ttb_usercon_palavra_passe.ForeColor = Color.DimGray;
                ttb_usercon_palavra_passe.UseSystemPasswordChar = false;
            }
        }

        private void Btn_usercon_entrar_Click(object sender, EventArgs e)
        {

            DataBase.Open();
            cmd_aluno.Connection = DataBase;
            cmd_funcionario.Connection = DataBase;


            int valor_funcionario = 0;
            int valor_aluno = 0;

            try
            {
                if (ttb_usercon_email.Text == "E-mail" && string.IsNullOrEmpty(ttb_usercon_email.Text))
                {
                    MessageBox.Show("Escreva o seu E-mail !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ttb_usercon_palavra_passe.Text == "Palavra-passe" && string.IsNullOrEmpty(ttb_usercon_palavra_passe.Text))
                {
                    MessageBox.Show("Escreva a sua palavra !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        cmd_aluno.CommandText = $"Select count(*) from aluno where Email = '{ttb_usercon_email.Text}'and Pass = '{ttb_usercon_palavra_passe.Text}';";
                        valor_aluno = int.Parse(cmd_aluno.ExecuteScalar().ToString());                      

                        cmd_funcionario.CommandText = $"Select count(*) from funcionario where Email = '{ttb_usercon_email.Text}'and Pass = '{ttb_usercon_palavra_passe.Text}';";      
                        valor_funcionario = int.Parse(cmd_funcionario.ExecuteScalar().ToString());

                        if (valor_funcionario == 1)
                        {
                            MessageBox.Show("Bem vindo caro funcionario!!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            BtnVisibi(this, e);

                            if (!pnl_usercon_login.Controls.Contains(user_control_bem_vindo.Instance))
                            {
                                pnl_usercon_login.Controls.Add(user_control_bem_vindo.Instance);
                                user_control_bem_vindo.Instance.Dock = DockStyle.Fill;
                                user_control_bem_vindo.Instance.BringToFront();
                            }
                            else
                            {
                                user_control_bem_vindo.Instance.BringToFront();
                            }

                            
                            
                        }
                        else if (valor_aluno == 1)
                        {
                            MessageBox.Show("Bem vindo caro aluno!!!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            OnBtnVisi(this, e);

                            if (!pnl_usercon_login.Controls.Contains(user_control_bem_vindo.Instance))
                            {
                                pnl_usercon_login.Controls.Add(user_control_bem_vindo.Instance);
                                user_control_bem_vindo.Instance.Dock = DockStyle.Fill;
                                user_control_bem_vindo.Instance.BringToFront();
                            }
                            else
                            {
                                user_control_bem_vindo.Instance.BringToFront();
                            }
                        }
                        else
                        {
                            MessageBox.Show("O seu email ou a sua palavra-passe esão incorretas.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nErro: {ex.Message}");
                    }
                    finally
                    {
                        if (DataBase.State == System.Data.ConnectionState.Open)
                        {
                            DataBase.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }

        private void Btn_ver_pass_Click(object sender, EventArgs e)
        {
            ttb_usercon_palavra_passe.UseSystemPasswordChar = false;
            btn_ver_pass.Visible = false;
            btn_nao_ver_pass.Visible = true;
        }

        private void Btn_nao_ver_pass_Click(object sender, EventArgs e)
        {
            ttb_usercon_palavra_passe.UseSystemPasswordChar = true;
            btn_ver_pass.Visible = true;
            btn_nao_ver_pass.Visible = false;
        }
    }
}
