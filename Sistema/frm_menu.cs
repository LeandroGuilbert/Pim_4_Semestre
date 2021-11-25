
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_consultaProdutos frm = new frm_consultaProdutos();
            frm.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_checkin frm = new frm_checkin();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_cliente frm = new frm_cliente();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_checkin frm = new frm_checkin();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_consultaProdutos frm = new frm_consultaProdutos();
            frm.Show();
        }
    }
}
