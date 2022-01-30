using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_Using_SQLite.Entities;

namespace GUI_Using_SQLite
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = tb_name.Text;
            user.username = tb_username.Text;
            user.password = tb_password.Text;
            user.status = cb_status.Text;
            user.userLevel = Convert.ToInt32(Math.Round(NUpDn_userLevel.Value, 0));
        }
    }
}
