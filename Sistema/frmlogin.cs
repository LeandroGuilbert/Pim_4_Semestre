using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace Sistema
{
    public partial class frmlogin : Form
    {
        public bool logado = false;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.tb_usuario.Count(
                x => x.usuario == txt_usuario.Text && x.senha == txt_senha.Text);

            if (user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usurio ou Senha Incorreta!");
            }

                
                    
                
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
