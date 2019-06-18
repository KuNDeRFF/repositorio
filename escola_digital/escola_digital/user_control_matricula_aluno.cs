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
using System.Net;
using System.Net.Mail;

namespace escola_digital
{
    public partial class user_control_matricula_aluno : UserControl
    {
        private static user_control_matricula_aluno _instance;

        public static user_control_matricula_aluno Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_matricula_aluno();
                return _instance;
            }
        }
        
        public user_control_matricula_aluno(/*user_control_verificacao_matricula vfm*/)
        {
            InitializeComponent();
        }

        private static MySqlConnection DataBase = new MySqlConnection("Server=localhost;Database=dt_escoladigital;Uid=root;Pwd=123456;");
        private static MySqlCommand cmd_confirmacao = new MySqlCommand();
        private static MySqlCommand cmd_aluno = new MySqlCommand();
        private static MySqlCommand cmd_pai = new MySqlCommand();
        private static MySqlCommand cmd_mae = new MySqlCommand();

        

        private string IDAluno = "";
        private string NomeCompleto = "";
        private string Profissao = "";
        private string ResideCom = "";
        private string LocalNascimento = "";
        private string NIF = "";
        private string Naturalidade = "";
        private string NIC = "";
        private string Telemovel = "";
        private string MoradaCompleta = "";
        private string Email = "";       
        private string dt = "";
        private string Sexo = "";
        private string Habilitacoes = "";

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void Ttb_nome_completo_TextChanged(object sender, EventArgs e)
        {
            NomeCompleto = Convert.ToString(ttb_nome_completo.Text);
        }               

        private void Ckb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Masculino";
        }

        private void Ckb_feminino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Feminino";
        }

        private void Ttb_outro_TextChanged(object sender, EventArgs e)
        {
            ResideCom = Convert.ToString(ttb_outro.Text);
        }              

        private void Ttb_local_de_nascimento_TextChanged(object sender, EventArgs e)
        {
            LocalNascimento = Convert.ToString(ttb_local_de_nascimento.Text);
        }

        private void Ttb_nif_TextChanged(object sender, EventArgs e)
        {
            NIF = Convert.ToString(ttb_nif.Text);
        }

        private void Ttb_naturalidade_TextChanged(object sender, EventArgs e)
        {
            Naturalidade = Convert.ToString(ttb_naturalidade.Text);
        }

        private void Ttb_nic_TextChanged(object sender, EventArgs e)
        {
            NIC = Convert.ToString(ttb_nic.Text);
        }

        private void Ttb_num_telemovel_TextChanged(object sender, EventArgs e)
        {
            Telemovel = Convert.ToString(ttb_num_telemovel.Text);
        }

        private void Ttb_morada_completa_TextChanged(object sender, EventArgs e)
        {
            MoradaCompleta = Convert.ToString(ttb_morada_completa.Text);
        }

        private void Ttb_email_TextChanged(object sender, EventArgs e)
        {
            Email = Convert.ToString(ttb_email.Text);
        }

        private void Ttb_IDAluno_TextChanged(object sender, EventArgs e)
        {
            IDAluno = Convert.ToString(ttb_IDAluno.Text);
        }

        private void Dtp_date_ValueChanged(object sender, EventArgs e)
        {
            dt = Convert.ToString(dtp_date.Text);
        }

        private void Ttb_habilitacoes_literarias_TextChanged(object sender, EventArgs e)
        {
            Habilitacoes = Convert.ToString(ttb_habilitacoes_literarias.Text);

        }

        private void Ttb_profissao_TextChanged(object sender, EventArgs e)
        {
            Profissao = Convert.ToString(ttb_profissao.Text);
        }

        private Boolean confirmar_matricula(string idaluno, MySqlCommand input)
        {
            MySqlDataReader resultado;                   


            try
            {
                input.CommandText = "SELECT 1 FROM dados_aluno_matricula WHERE IDAluno = @IDAluno";
                input.Parameters.Add("@IDAluno", MySqlDbType.Int64).Value = Convert.ToInt64(IDAluno);

                resultado = input.ExecuteReader();

                if(resultado.HasRows)
                {
                   
                    Console.WriteLine("Este aluno ja fez a matricula.");
                    resultado.Close();
                    input.Parameters.Clear();
                    return true;
                }
                resultado.Close();
                input.Parameters.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nErro no boolean: {ex.Message}");
            }

            Console.WriteLine("Não existe matricula deste aluno");           
            
            return false;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            
            cmd_confirmacao.Connection = DataBase;

            try
            {
                DataBase.Open();

                if(!string.IsNullOrEmpty(IDAluno))
                {
                    if (confirmar_matricula(Convert.ToString(IDAluno), cmd_confirmacao))
                    {
                        MessageBox.Show("Este aluno já tem a matricula feita", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        pnl_confirmacao_aluno.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Falta inserir o número de aluno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro no btn_ok_click: {ex.Message}");
            }
            finally
            {
                if (DataBase.State == System.Data.ConnectionState.Open)
                {
                    DataBase.Close();
                }
            }
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {            
            cmd_aluno.Connection = DataBase;
            
            try
            {
                
                DataBase.Open();

                if (!string.IsNullOrEmpty(NomeCompleto) && !string.IsNullOrEmpty(Sexo) &&
                    !string.IsNullOrEmpty(ResideCom) && !string.IsNullOrEmpty(dt) &&
                    !string.IsNullOrEmpty(LocalNascimento) && !string.IsNullOrEmpty(NIF) &&
                    !string.IsNullOrEmpty(Naturalidade) && !string.IsNullOrEmpty(NIC) &&
                    !string.IsNullOrEmpty(Telemovel) && !string.IsNullOrEmpty(MoradaCompleta) &&
                    !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(IDAluno))
                {
                    cmd_aluno.CommandText ="INSERT INTO dados_aluno_matricula(IDAluno, NomeCompleto, Sexo, ResideCom, DataNascimento, LocalNascimento, NIF, Naturalidade, NIC, MoradaCompleta, Email, Telemovel) " +
                        "values (@numaluno, @NomeCompleto, @Sexo, @ResideCom, @dt, @LocalNascimento, @NIF, @Naturalidade, @NIC, @MoradaCompleta, @Email, @Telemovel)";

                    
                    cmd_aluno.Parameters.Add("@numaluno", MySqlDbType.Int64).Value = Convert.ToInt64(IDAluno);
                    cmd_aluno.Parameters.Add("@NomeCompleto", MySqlDbType.String).Value = Convert.ToString(NomeCompleto);
                    cmd_aluno.Parameters.Add("@Sexo", MySqlDbType.String).Value = Convert.ToString(Sexo);
                    cmd_aluno.Parameters.Add("@ResideCom", MySqlDbType.String).Value = Convert.ToString(ResideCom);
                    cmd_aluno.Parameters.Add("@dt", MySqlDbType.DateTime).Value = Convert.ToDateTime(dt);
                    cmd_aluno.Parameters.Add("@LocalNascimento", MySqlDbType.String).Value = Convert.ToString(LocalNascimento);
                    cmd_aluno.Parameters.Add("@NIF", MySqlDbType.Int64).Value = Convert.ToInt64(NIF);
                    cmd_aluno.Parameters.Add("@Naturalidade", MySqlDbType.String).Value = Convert.ToString(Naturalidade);
                    cmd_aluno.Parameters.Add("@NIC", MySqlDbType.Int64).Value = Convert.ToInt64(NIC);
                    cmd_aluno.Parameters.Add("@Telemovel", MySqlDbType.Int64).Value = Convert.ToInt64(Telemovel);
                    cmd_aluno.Parameters.Add("@MoradaCompleta", MySqlDbType.String).Value = Convert.ToString(MoradaCompleta);
                    cmd_aluno.Parameters.Add("@Email", MySqlDbType.String).Value = Convert.ToString(Email);                    

                                                        
                    int lc_tabela_dados_aluno_matricula = cmd_aluno.ExecuteNonQuery();
                    
                    if(lc_tabela_dados_aluno_matricula > 0)
                    {
                        MessageBox.Show($"Dados do aluno armazenados com sucesso.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    lbl_dados_do_aluno.Text = "Dados do Pai";

                    //visibilidades verdadeiras
                    btn_next_1.Visible = true;
                    lbl_profissao.Visible = true;
                    lbl_habilitacoes_literarias.Visible = true;
                    ttb_profissao.Visible = true;
                    ttb_habilitacoes_literarias.Visible = true;
                    //pnl_confirmacao_aluno.Visible = true;

                    //visibilidade falses
                    btn_next.Visible = false;                    
                    btn_finalizar.Visible = false;                    
                    lbl_sexo.Visible = false;
                    ckb_feminino.Visible = false;
                    ckb_masculino.Visible = false;
                    lbl_residencia.Visible = false;
                    btn_ok.Visible = false;

                    Action<Control.ControlCollection> func = null;

                    func = (controls) =>
                    {
                        foreach (Control control in controls)
                        {
                            if (control is TextBox)
                            {
                                (control as TextBox).Clear();
                            }
                            else
                            {
                                func(control.Controls);
                            }
                        }
                    };
                    func(Controls);
                }
                else
                {
                    /*MessageBox.Show($"Email:{Email}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Morada:{MoradaCompleta}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Telemovel:{Telemovel}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"NIC:{NIC}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Naturalidade:{Naturalidade}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"NIF:{NIF}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Localnas:{LocalNascimento}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"time:{dt}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Reside:{ResideCom}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"sexo:{Sexo}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"nome completo:{NomeCompleto}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"idaluno:{IDAluno}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    MessageBox.Show("Faltam inserir dados no formúlario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd_aluno.Parameters.Clear();
            }
            catch (Exception ex)
            {
                cmd_aluno.Parameters.Clear();
                Console.WriteLine($"\nErro btn_next_click: {ex.Message}");
            }
            finally
            {               
                if (DataBase.State == System.Data.ConnectionState.Open)
                {
                    DataBase.Close();
                }
                cmd_aluno.Parameters.Clear();
            }
            insert();
        }

        private void Btn_next_1_Click(object sender, EventArgs e)
        {
            cmd_pai.Connection = DataBase;

            try
            {

                DataBase.Open();

                if (!string.IsNullOrEmpty(NomeCompleto) && !string.IsNullOrEmpty(Profissao) &&
                    !string.IsNullOrEmpty(Habilitacoes) && !string.IsNullOrEmpty(dt) &&
                    !string.IsNullOrEmpty(LocalNascimento) && !string.IsNullOrEmpty(NIF) &&
                    !string.IsNullOrEmpty(Naturalidade) && !string.IsNullOrEmpty(NIC) &&
                    !string.IsNullOrEmpty(Telemovel) && !string.IsNullOrEmpty(MoradaCompleta) &&
                    !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(IDAluno))
                {

                    

                    cmd_pai.CommandText = "INSERT INTO dados_pai_matricula  (IDAluno, NomeCompleto, Profissao, Habilitacoes, DataNascimento, LocalNascimento, NIF, Naturalidade, NIC, MoradaCompleta, Email, Telemovel) " +
                        "values (@numaluno_pai, @NomeCompleto, @Profissao, @Habilitacoes, @dt, @LocalNascimento, @NIF, @Naturalidade, @NIC, @MoradaCompleta, @Email, @Telemovel)";


                    cmd_pai.Parameters.Add("@numaluno_pai", MySqlDbType.Int64).Value = Convert.ToInt64(IDAluno);
                    cmd_pai.Parameters.Add("@NomeCompleto", MySqlDbType.String).Value = Convert.ToString(NomeCompleto);
                    cmd_pai.Parameters.Add("@Profissao", MySqlDbType.String).Value = Convert.ToString(Profissao);
                    cmd_pai.Parameters.Add("@Habilitacoes", MySqlDbType.String).Value = Convert.ToString(Habilitacoes);
                    cmd_pai.Parameters.Add("@dt", MySqlDbType.DateTime).Value = Convert.ToDateTime(dt);
                    cmd_pai.Parameters.Add("@LocalNascimento", MySqlDbType.String).Value = Convert.ToString(LocalNascimento);
                    cmd_pai.Parameters.Add("@NIF", MySqlDbType.Int64).Value = Convert.ToInt64(NIF);
                    cmd_pai.Parameters.Add("@Naturalidade", MySqlDbType.String).Value = Convert.ToString(Naturalidade);
                    cmd_pai.Parameters.Add("@NIC", MySqlDbType.Int64).Value = Convert.ToInt64(NIC);
                    cmd_pai.Parameters.Add("@Telemovel", MySqlDbType.Int64).Value = Convert.ToInt64(Telemovel);
                    cmd_pai.Parameters.Add("@MoradaCompleta", MySqlDbType.String).Value = Convert.ToString(MoradaCompleta);
                    cmd_pai.Parameters.Add("@Email", MySqlDbType.String).Value = Convert.ToString(Email);


                    //cmd_pai.ExecuteNonQuery();

                    int lc_tabela_dados_pai_matricula = cmd_pai.ExecuteNonQuery();

                    if (lc_tabela_dados_pai_matricula > 0)
                    {
                        MessageBox.Show($"Dados do aluno armazenados com sucesso.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    if (DataBase.State == System.Data.ConnectionState.Open)
                    {
                        DataBase.Close();
                    }

                    Action<Control.ControlCollection> func = null;

                    func = (controls) =>
                    {
                        foreach (Control control in controls)
                        {
                            if (control is TextBox)
                            {
                                (control as TextBox).Clear();
                            }
                            else
                            {
                                func(control.Controls);
                            }
                        }
                    };
                    func(Controls);

                    lbl_dados_do_aluno.Text = "Dados da Mãe";

                    //visibilidades verdadeiras
                    
                    btn_finalizar.Visible = true;
                    lbl_profissao.Visible = true;
                    lbl_habilitacoes_literarias.Visible = true;
                    ttb_profissao.Visible = true;
                    ttb_habilitacoes_literarias.Visible = true;
                    //pnl_confirmacao_aluno.Visible = true;

                    //visibilidade falses
                    btn_next.Visible = false;
                    btn_next_1.Visible = false;
                    lbl_sexo.Visible = false;
                    ckb_feminino.Visible = false;
                    ckb_masculino.Visible = false;
                    lbl_residencia.Visible = false;                    
                    btn_ok.Visible = false;
                    
                    

                }
                else
                {
                    /*MessageBox.Show($"Email:{Email}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Morada:{MoradaCompleta}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Telemovel:{Telemovel}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"NIC:{NIC}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Naturalidade:{Naturalidade}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"NIF:{NIF}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Localnas:{LocalNascimento}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"time:{dt}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Reside:{ResideCom}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"sexo:{Sexo}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"nome completo:{NomeCompleto}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"idaluno:{IDAluno}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    MessageBox.Show("Faltam inserir dados no formúlario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd_pai.Parameters.Clear();
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
        
        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            cmd_mae.Connection = DataBase;

            try
            {

                DataBase.Open();

                if (!string.IsNullOrEmpty(NomeCompleto) && !string.IsNullOrEmpty(Profissao) &&
                    !string.IsNullOrEmpty(Habilitacoes) && !string.IsNullOrEmpty(dt) &&
                    !string.IsNullOrEmpty(LocalNascimento) && !string.IsNullOrEmpty(NIF) &&
                    !string.IsNullOrEmpty(Naturalidade) && !string.IsNullOrEmpty(NIC) &&
                    !string.IsNullOrEmpty(Telemovel) && !string.IsNullOrEmpty(MoradaCompleta) &&
                    !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(IDAluno))
                {
                    cmd_mae.CommandText = "INSERT INTO dados_mae_matricula(IDAluno, NomeCompleto, Profissao, Habilitacoes, DataNascimento, LocalNascimento, NIF, Naturalidade, NIC, MoradaCompleta, Email, Telemovel) " +
                         "values (@numaluno_mae, @NomeCompleto, @Profissao, @Habilitacoes, @dt, @LocalNascimento, @NIF, @Naturalidade, @NIC, @MoradaCompleta, @Email, @Telemovel)";


                    cmd_mae.Parameters.Add("@numaluno_mae", MySqlDbType.Int64).Value = Convert.ToInt64(IDAluno);
                    cmd_mae.Parameters.Add("@NomeCompleto", MySqlDbType.String).Value = Convert.ToString(NomeCompleto);
                    cmd_mae.Parameters.Add("@Profissao", MySqlDbType.String).Value = Convert.ToString(Profissao);
                    cmd_mae.Parameters.Add("@Habilitacoes", MySqlDbType.String).Value = Convert.ToString(Habilitacoes);
                    cmd_mae.Parameters.Add("@dt", MySqlDbType.DateTime).Value = Convert.ToDateTime(dt);
                    cmd_mae.Parameters.Add("@LocalNascimento", MySqlDbType.String).Value = Convert.ToString(LocalNascimento);
                    cmd_mae.Parameters.Add("@NIF", MySqlDbType.Int64).Value = Convert.ToInt64(NIF);
                    cmd_mae.Parameters.Add("@Naturalidade", MySqlDbType.String).Value = Convert.ToString(Naturalidade);
                    cmd_mae.Parameters.Add("@NIC", MySqlDbType.Int64).Value = Convert.ToInt64(NIC);
                    cmd_mae.Parameters.Add("@Telemovel", MySqlDbType.Int64).Value = Convert.ToInt64(Telemovel);
                    cmd_mae.Parameters.Add("@MoradaCompleta", MySqlDbType.String).Value = Convert.ToString(MoradaCompleta);
                    cmd_mae.Parameters.Add("@Email", MySqlDbType.String).Value = Convert.ToString(Email);
                 

                    int lc_tabela_dados_mae_matricula = cmd_mae.ExecuteNonQuery();

                    if (lc_tabela_dados_mae_matricula > 0)
                    {
                        MessageBox.Show($"Dados do mae armazenados com sucesso.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (DataBase.State == System.Data.ConnectionState.Open)
                    {
                        DataBase.Close();
                    }

                    Action<Control.ControlCollection> func = null;

                    func = (controls) =>
                    {
                        foreach (Control control in controls)
                        {
                            if (control is TextBox)
                            {
                                (control as TextBox).Clear();
                            }
                            else
                            {
                                func(control.Controls);
                            }
                        }
                    };
                    func(Controls);


                }
                else
                {
                    /*MessageBox.Show($"Email:{Email}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Morada:{MoradaCompleta}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Telemovel:{Telemovel}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"NIC:{NIC}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Naturalidade:{Naturalidade}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"NIF:{NIF}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Localnas:{LocalNascimento}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"time:{dt}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Reside:{ResideCom}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"sexo:{Sexo}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"nome completo:{NomeCompleto}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"idaluno:{IDAluno}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    MessageBox.Show("Faltam inserir dados no formúlario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd_mae.Parameters.Clear();
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
}
