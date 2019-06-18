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
    public partial class user_control_escolher_resgisto_aluno : UserControl
    {
        private static user_control_escolher_resgisto_aluno _instance;

        public static user_control_escolher_resgisto_aluno Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_escolher_resgisto_aluno();
                return _instance;
            }
        }
        
        private static MySqlConnection DataBase = new MySqlConnection("Server=localhost;Database=dt_escoladigital;Uid=root;Pwd=123456;");
        private static MySqlCommand inserirDados = new MySqlCommand();

        private string PrimeiroNome = "";
        private string Apelido = "";
        private string Numero = "";
        private string Turma = "";
        private string Curso = "";
        private string NIF = "";
        private string Email = "";
        private string Pass = "";
        private string Telemovel = "";

        public user_control_escolher_resgisto_aluno()
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

        private void Ttb_numero_TextChanged(object sender, EventArgs e)
        {
            Numero = Convert.ToString(ttb_numero.Text);
        }

        private void Ttb_turma_TextChanged(object sender, EventArgs e)
        {
            Turma = Convert.ToString(ttb_turma.Text);
        }

        private void Ttb_num_cc_TextChanged(object sender, EventArgs e)
        {
            NIF = Convert.ToString(ttb_num_cc.Text);
        }

        private void Ttb_email_TextChanged(object sender, EventArgs e)
        {
            Email = Convert.ToString(ttb_email.Text);
        }

        private void Cb_curso_TextChanged(object sender, EventArgs e)
        {
            if (cb_curso.Text == "Curso Professional de Gestão de Equipamentos Informáticos")
            {
                Curso = Convert.ToString(cb_curso.Text);
            }
            else if (cb_curso.Text == "Curso Profissional de Gestão e Programação de Sistemas Informáticos")
            {
                Curso = Convert.ToString(cb_curso.Text);
            }
            else if (cb_curso.Text == "Curso Profissional de Fotografia")
            {
                Curso = Convert.ToString(cb_curso.Text);
            }
            else if (cb_curso.Text == "Curso Profissional de Multimédia")
            {
                Curso = Convert.ToString(cb_curso.Text);
            }
            else if (cb_curso.Text == "Curso Profissional de Desenho Digital 3D")
            {
                Curso = Convert.ToString(cb_curso.Text);
            }
            
        }

        private void Ttb_telemovel_TextChanged(object sender, EventArgs e)
        {
            Telemovel = Convert.ToString(ttb_telemovel.Text);
        }

        private void Ttb_password_TextChanged(object sender, EventArgs e)
        {
            Pass = Convert.ToString(ttb_password.Text);
            ttb_password.UseSystemPasswordChar = true;
        }       

        private Boolean confirmacao_email(string user, MySqlCommand input)
        {
            MySqlDataReader resultado;

            try
            {
                input.CommandText = "select 1 from aluno where Email=@mail";
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
            //MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = DataBase;

            try
            {
                DataBase.Open();

                if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(Apelido) && 
                    !string.IsNullOrEmpty(Numero) && !string.IsNullOrEmpty(Turma) &&
                    !string.IsNullOrEmpty(Curso) && !string.IsNullOrEmpty(NIF) &&
                    !string.IsNullOrEmpty(Telemovel) && !string.IsNullOrEmpty(Email) &&
                    !string.IsNullOrEmpty(Pass))
                
                {
                    if (confirmacao_email(Convert.ToString(Email), inserirDados))
                    {
                        MessageBox.Show("Este email ja existe.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                    else
                    {
                        inserirDados.CommandText = "INSERT INTO aluno (PrimeiroNome, Apelido, Numero, NIF, Telemovel, Email, Pass) " +
                            "values (@PrimeiroNome, @Apelido, @Numero, @NIF, @Telemovel, @Email, @Pass);";

                        inserirDados.Parameters.Add("@PrimeiroNome", MySqlDbType.String).Value = Convert.ToString(PrimeiroNome);
                        inserirDados.Parameters.Add("@Apelido", MySqlDbType.String).Value = Convert.ToString(Apelido);
                        inserirDados.Parameters.Add("@Numero", MySqlDbType.Int64).Value = Convert.ToInt64(Numero);
                        inserirDados.Parameters.Add("@NIF", MySqlDbType.Int64).Value = Convert.ToInt64(NIF);
                        inserirDados.Parameters.Add("@Telemovel", MySqlDbType.Int64).Value = Convert.ToInt64(Telemovel);
                        inserirDados.Parameters.Add("@Email", MySqlDbType.String).Value = Convert.ToString(Email);
                        inserirDados.Parameters.Add("@Pass", MySqlDbType.String).Value = Convert.ToString(Pass);

                        int lc_tabela_aluno = inserirDados.ExecuteNonQuery();

                        //MessageBox.Show($"{lc_tabela_aluno}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        inserirDados.CommandText = "insert into curso (Turma, NomeCurso) values (@Turma, @Curso);";

                        inserirDados.Parameters.Add("@Turma", MySqlDbType.String).Value = Convert.ToString(Turma);
                        inserirDados.Parameters.Add("@Curso", MySqlDbType.String).Value = Convert.ToString(Curso);

                        int lc_tabela_curso = inserirDados.ExecuteNonQuery();

                        //MessageBox.Show($"{lc_tabela_curso}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (lc_tabela_aluno > 0 && lc_tabela_curso > 0)
                            MessageBox.Show($"Foi inserido um aluno com o email: {Email}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Faltam inserir dados no formúlario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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

                if (!pnl_usercon_escolher_resgisto_aluno.Controls.Contains(user_control_login.Instance))
                {
                    pnl_usercon_escolher_resgisto_aluno.Controls.Add(user_control_login.Instance);
                    user_control_login.Instance.Dock = DockStyle.Fill;
                    user_control_login.Instance.BringToFront();
                }
                else
                {
                    user_control_login.Instance.BringToFront();
                }
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
