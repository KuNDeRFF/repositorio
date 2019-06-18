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
    public partial class user_control_verificacao_matricula : UserControl
    {

        private static user_control_verificacao_matricula _instance;

        public static user_control_verificacao_matricula Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_verificacao_matricula();
                return _instance;
            }
        }

        string connect = "Server=localhost;Database=dt_escoladigital;Uid=root;Pwd=123456;";
        

        public user_control_verificacao_matricula()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        
        //
        //O "DataTabel" é o codigo que permite fazer o upload das colunas da tabela 'dados_aluno_matricula' no DataGridView 'dgv_matriculas'.
        //
        public DataTable Source()
        {
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();
            try
            {
                
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM dados_aluno_matricula, dados_mae_matricula, dados_pai_matricula";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                ds.Clear();
                adap.Fill(ds);
                dt = ds.Tables[0];
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro btn_next_click: {ex.Message}");
            }

            return dt;
        }

        private void F2_UpdateEventHandler1(object sender, user_control_matricula_aluno.UpdateEventArgs args)
        {
            dgv_matriculas.DataSource = Source();
        }

        private void User_control_verificacao_matricula_Load(object sender, EventArgs e)
        {
            
            dgv_matriculas.DataSource = Source();
        }

        //
        //Click do botão que no premite aceder ao 'user_control_email'.
        //
        private void Btn_email_Click(object sender, EventArgs e)
        {
            if (!pnl_verificacao_matricula.Controls.Contains(user_control_email.Instance))
            {
                pnl_verificacao_matricula.Controls.Add(user_control_email.Instance);
                user_control_email.Instance.Dock = DockStyle.Fill;
                user_control_email.Instance.BringToFront();
            }
            else
            {
                user_control_email.Instance.BringToFront();
            }
        }

        private void Btn_procurar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connect))
            {
                con.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("AlunoSearchByValue", con);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_SearchValue", ttb_procurar.Text);
                DataTable dtaluno = new DataTable();
                sqlda.Fill(dtaluno);
                dgv_matriculas.DataSource = dtaluno;
                dgv_matriculas.Columns[0].Visible = false;
            }
        }     

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connect))
            {
                con.Open();

                MySqlCommand sqlcmd = new MySqlCommand("AlunoDeleteByValue", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("_SearchValue", ttb_apagar_idaluno.Text);
                sqlcmd.ExecuteNonQuery();
                
                
                MessageBox.Show("Apagado com sucesso.");

            }
        }
    }
}
