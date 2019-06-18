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
    public partial class user_control_bem_vindo : UserControl
    {
        private static user_control_bem_vindo _instance;

        public static user_control_bem_vindo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_control_bem_vindo();
                return _instance;
            }
        }

        public user_control_bem_vindo()
        {
            InitializeComponent();
        }
    }
}
