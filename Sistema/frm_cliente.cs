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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_sistemaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_sistemaDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bd_sistemaDataSet.tb_cliente);

        }
    }
}
