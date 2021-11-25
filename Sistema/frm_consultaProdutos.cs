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
    public partial class frm_consultaProdutos : Form
    {
        public frm_consultaProdutos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)CB_categoria.SelectedValue);
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto.Where(x => x.CodigoCategoria == codigoCategoria);
        }

        private void CB_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_consultaProdutos_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }
    }
}
