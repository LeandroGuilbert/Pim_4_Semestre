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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Produto Inserido com Sucesso!");

            }
        }
            private bool valida()
            {
                if (txt_descricao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo de Categoria é obrigatório");
                    txt_descricao.Focus();
                    return false;
                }
                return true;
            }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                    this.produtoBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Excluida com Sucesso!");

                }
            }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }

        private void CB_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
    

