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
    public partial class frm_checkin : Form
    {
        public frm_checkin()
        {
            InitializeComponent();
        }

        private void CB_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_checkin_Load(object sender, EventArgs e)
        {
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja finalizar o Check-in ?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }

            if (MessageBox.Show("Check-in Realizado com Sucesso!", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }

            this.Dispose();
        }
    }
}
