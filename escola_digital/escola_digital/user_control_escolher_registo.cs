using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escola_digital
{
    public partial class user_control_escolher_registo : UserControl
    {
        private static user_control_escolher_registo _instance;

        public static user_control_escolher_registo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_escolher_registo();
                return _instance;
            }
        }

        public user_control_escolher_registo()
        {
            InitializeComponent();
        }

        private void Btn_usercon_escolha_estudante_Click_1(object sender, EventArgs e)
        {
            if (!pnl_usercon_escolher_registo.Controls.Contains(user_control_escolher_resgisto_aluno.Instance))
            {
                this.pnl_usercon_escolher_registo.Hide();

                pnl_usercon_escolher_registo.Controls.Add(user_control_escolher_resgisto_aluno.Instance);
                user_control_escolher_resgisto_aluno.Instance.Dock = DockStyle.Fill;
                user_control_escolher_resgisto_aluno.Instance.BringToFront();
            }
            else
            {
                user_control_escolher_resgisto_aluno.Instance.BringToFront();
            }
        }

        private void Btn_usercon_escolha_funcionario_Click(object sender, EventArgs e)
        {
            if (!pnl_usercon_escolher_registo.Controls.Contains(user_control_escolher_resgisto_funcioário.Instance))
            {
                this.pnl_usercon_escolher_registo.Hide();

                pnl_usercon_escolher_registo.Controls.Add(user_control_escolher_resgisto_funcioário.Instance);
                user_control_escolher_resgisto_funcioário.Instance.Dock = DockStyle.Fill;
                user_control_escolher_resgisto_funcioário.Instance.BringToFront();
            }
            else
            {
                user_control_escolher_resgisto_funcioário.Instance.BringToFront();
            }
        }

        
    }
}
