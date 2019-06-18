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
    public partial class user_control_escolher_resgisto_funcioário : UserControl
    {
        private static user_control_escolher_resgisto_funcioário _instance;

        public static user_control_escolher_resgisto_funcioário Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_escolher_resgisto_funcioário();
                return _instance;
            }
        }

        private static string _connectionString = "Server=localhost;Database=dt_escoladigital;Uid=root;Pwd=123456;";
        private static MySqlConnection DataBase = new MySqlConnection(_connectionString);

        private string PrimeiroNome = "";
        private string Apelido = "";
        private string NumeroFuncionario = "";
        private string NIF = "";
        private string Email = "";
        private string Pass = "";

        public user_control_escolher_resgisto_funcioário()
        {
            InitializeComponent();
        }

        private void Ttb_primerio_nome_TextChanged(object sender, EventArgs e)
        {
            PrimeiroNome = Convert.ToString(ttb_primerio_nome.Text);
        }

        private void Ttb_apelido_TextChanged(object sender, EventArgs e)
        {
            Apelido = Convert.ToString(ttb_apelido.Text);
        }

        private void Ttb_numero_funcionario_TextChanged(object sender, EventArgs e)
        {
            NumeroFuncionario = Convert.ToString(ttb_numero_funcionario.Text);
        }

        private void Ttb_num_cc_TextChanged(object sender, EventArgs e)
        {
            NIF = Convert.ToString(ttb_num_cc.Text);
        }

        private void Ttb_email_TextChanged(object sender, EventArgs e)
        {
            Email = Convert.ToString(ttb_email.Text);
        }

        private void Ttb_password_TextChanged(object sender, EventArgs e)
        {
            Pass = Convert.ToString(ttb_password.Text);
            ttb_password.UseSystemPasswordChar = true;
        }

        private void caixa_info(string cabeçalho, string msg)
        {
            string mensagem = msg;
            string caption = cabeçalho;
            MessageBoxButtons botao = MessageBoxButtons.OK;
            MessageBox.Show(mensagem, caption, botao);
        }

        private Boolean confirmacao_email(string user, MySqlCommand input)
        {
            MySqlDataReader resultado;

            try
            {
                input.CommandText = "select 1 from funcionario where Email=@mail";
                input.Parameters.Add("@mail", MySqlDbType.String).Value = Convert.ToString(Email);

                resultado = input.ExecuteReader();

                if (resultado.HasRows)
                {
                    Console.WriteLine("Ja existe um utilizador com este email!");
                    resultado.Close();
                    return true;
                }
                resultado.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }

            Console.WriteLine("Não existe user.");
            return false;
        }

        private void Btn_submeter_Click(object sender, EventArgs e)
        {
            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = DataBase;

            try
            {
                DataBase.Open();

                if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(Apelido) &&
                    !string.IsNullOrEmpty(NumeroFuncionario) && !string.IsNullOrEmpty(NIF) && 
                    !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Pass))

                {
                    if (confirmacao_email(Convert.ToString(Email), inserirDados))
                    {
                        caixa_info("Erro", "email já existe");
                    }


                    else
                    {
                        inserirDados.CommandText = "insert into funcionario (PrimeiroNome, Apelido, NumeroFuncionario, NIF, Email, Pass) values (@PrimeiroNome, @Apelido, @NumeroFuncionario, @NIF, @Email, @Pass)";

                        inserirDados.Parameters.Add("@PrimeiroNome", MySqlDbType.String).Value = Convert.ToString(PrimeiroNome);
                        inserirDados.Parameters.Add("@Apelido", MySqlDbType.String).Value = Convert.ToString(Apelido);
                        inserirDados.Parameters.Add("@NumeroFuncionario", MySqlDbType.Int64).Value = Convert.ToInt64(NumeroFuncionario);
                        inserirDados.Parameters.Add("@NIF", MySqlDbType.Int64).Value = Convert.ToInt64(NIF);     
                        inserirDados.Parameters.Add("@Email", MySqlDbType.String).Value = Convert.ToString(Email);
                        inserirDados.Parameters.Add("@Pass", MySqlDbType.String).Value = Convert.ToString(Pass);

                        int linhasCriadas = inserirDados.ExecuteNonQuery();

                        if (linhasCriadas > 0)
                            caixa_info("Sucesso", "Foi inserido um novo user com o email " + Email);
                    }
                }
                else
                {
                    caixa_info("Erro", "Faltam inserir dados no formulário.");
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


            if (!pnl_usercon_resgito_funionário.Controls.Contains(user_control_login.Instance))
            {
                pnl_usercon_resgito_funionário.Controls.Add(user_control_login.Instance);
                user_control_login.Instance.Dock = DockStyle.Fill;
                user_control_login.Instance.BringToFront();
            }
            else
            {
                user_control_login.Instance.BringToFront();
            }
        }

        private void Btn_ver_pass_Click(object sender, EventArgs e)
        {
            ttb_password.UseSystemPasswordChar = false;
            btn_ver_pass.Visible = false;
            btn_nao_ver_pass.Visible = true;
        }

        private void Btn_nao_ver_pass_Click(object sender, EventArgs e)
        {
            ttb_password.UseSystemPasswordChar = true;
            btn_ver_pass.Visible = true;
            btn_nao_ver_pass.Visible = false;
        }
    }
}
