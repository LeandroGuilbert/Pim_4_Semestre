
namespace Sistema
{
    partial class frm_venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataPagamentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.txt_data_venc = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_pgto = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_venda = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_valortotal = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_novoitem = new System.Windows.Forms.Button();
            this.CB_produto = new System.Windows.Forms.ComboBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DG_Vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataPagamentoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(27, 35);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(39, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente";
            codigoPessoaLabel.Click += new System.EventHandler(this.codigoPessoaLabel_Click);
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(6, 29);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(6, 106);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(23, 139);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(23, 68);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 8;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(112, 416);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(61, 13);
            valorPagoLabel.TabIndex = 23;
            valorPagoLabel.Text = "Valor Total:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(118, 374);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 22;
            descontoLabel.Text = "Desconto:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(140, 336);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 21;
            valorLabel1.Text = "Valor:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(286, 339);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(111, 13);
            codigoStatusLabel.TabIndex = 29;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // dataPagamentoLabel
            // 
            dataPagamentoLabel.AutoSize = true;
            dataPagamentoLabel.Location = new System.Drawing.Point(286, 377);
            dataPagamentoLabel.Name = "dataPagamentoLabel";
            dataPagamentoLabel.Size = new System.Drawing.Size(90, 13);
            dataPagamentoLabel.TabIndex = 30;
            dataPagamentoLabel.Text = "Data Pagamento:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.DAL.Venda);
            // 
            // CB_cliente
            // 
            this.CB_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CB_cliente.DataSource = this.pessoasBindingSource;
            this.CB_cliente.DisplayMember = "Descricao";
            this.CB_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cliente.FormattingEnabled = true;
            this.CB_cliente.Location = new System.Drawing.Point(72, 32);
            this.CB_cliente.Name = "CB_cliente";
            this.CB_cliente.Size = new System.Drawing.Size(121, 21);
            this.CB_cliente.TabIndex = 2;
            this.CB_cliente.ValueMember = "Codigo";
            this.CB_cliente.SelectedIndexChanged += new System.EventHandler(this.CB_cliente_SelectedIndexChanged);
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(sistema.DAL.Pessoas);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo Aluguel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Controls.Add(dataPagamentoLabel);
            this.groupBox1.Controls.Add(this.txt_data_venc);
            this.groupBox1.Controls.Add(codigoStatusLabel);
            this.groupBox1.Controls.Add(this.CB_pgto);
            this.groupBox1.Controls.Add(this.btn_venda);
            this.groupBox1.Controls.Add(this.btn_pedido);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.txt_valortotal);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.btn_novoitem);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(this.CB_produto);
            this.groupBox1.Controls.Add(this.DG_Vendas);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Location = new System.Drawing.Point(46, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 472);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(447, 443);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(97, 23);
            this.btn_finalizar.TabIndex = 32;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // txt_data_venc
            // 
            this.txt_data_venc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataPagamento", true));
            this.txt_data_venc.Enabled = false;
            this.txt_data_venc.Location = new System.Drawing.Point(399, 373);
            this.txt_data_venc.Name = "txt_data_venc";
            this.txt_data_venc.Size = new System.Drawing.Size(185, 20);
            this.txt_data_venc.TabIndex = 31;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(sistema.DAL.ContasReceber);
            // 
            // CB_pgto
            // 
            this.CB_pgto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "CodigoStatus", true));
            this.CB_pgto.DataSource = this.statusPagamentoBindingSource;
            this.CB_pgto.DisplayMember = "Status";
            this.CB_pgto.Enabled = false;
            this.CB_pgto.FormattingEnabled = true;
            this.CB_pgto.Location = new System.Drawing.Point(399, 336);
            this.CB_pgto.Name = "CB_pgto";
            this.CB_pgto.Size = new System.Drawing.Size(185, 21);
            this.CB_pgto.TabIndex = 30;
            this.CB_pgto.ValueMember = "CodigoStatus";
            this.CB_pgto.SelectedIndexChanged += new System.EventHandler(this.CB_pgto_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(sistema.DAL.StatusPagamento);
            // 
            // btn_venda
            // 
            this.btn_venda.Enabled = false;
            this.btn_venda.Location = new System.Drawing.Point(9, 374);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(97, 23);
            this.btn_venda.TabIndex = 29;
            this.btn_venda.Text = "Finalizar Venda";
            this.btn_venda.UseVisualStyleBackColor = true;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // btn_pedido
            // 
            this.btn_pedido.Location = new System.Drawing.Point(9, 336);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(97, 23);
            this.btn_pedido.TabIndex = 28;
            this.btn_pedido.Text = "Finalizar Pedido";
            this.btn_pedido.UseVisualStyleBackColor = true;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(9, 413);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(97, 23);
            this.btn_imprimir.TabIndex = 27;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // txt_valortotal
            // 
            this.txt_valortotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_valortotal.Location = new System.Drawing.Point(180, 413);
            this.txt_valortotal.Name = "txt_valortotal";
            this.txt_valortotal.ReadOnly = true;
            this.txt_valortotal.Size = new System.Drawing.Size(100, 20);
            this.txt_valortotal.TabIndex = 26;
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(180, 374);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 25;
            // 
            // txt_valor
            // 
            this.txt_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_valor.Location = new System.Drawing.Point(180, 336);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 24;
            // 
            // btn_novoitem
            // 
            this.btn_novoitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novoitem.Location = new System.Drawing.Point(255, 87);
            this.btn_novoitem.Name = "btn_novoitem";
            this.btn_novoitem.Size = new System.Drawing.Size(75, 23);
            this.btn_novoitem.TabIndex = 10;
            this.btn_novoitem.Text = "Novo Item";
            this.btn_novoitem.UseVisualStyleBackColor = true;
            this.btn_novoitem.Click += new System.EventHandler(this.btn_novoitem_Click);
            // 
            // CB_produto
            // 
            this.CB_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.CB_produto.DataSource = this.produtoBindingSource;
            this.CB_produto.DisplayMember = "Descricao";
            this.CB_produto.FormattingEnabled = true;
            this.CB_produto.Location = new System.Drawing.Point(95, 65);
            this.CB_produto.Name = "CB_produto";
            this.CB_produto.Size = new System.Drawing.Size(121, 21);
            this.CB_produto.TabIndex = 9;
            this.CB_produto.ValueMember = "Codigo";
            this.CB_produto.SelectedIndexChanged += new System.EventHandler(this.CB_produto_SelectedIndexChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(sistema.DAL.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(sistema.DAL.Produto);
            // 
            // DG_Vendas
            // 
            this.DG_Vendas.AllowUserToAddRows = false;
            this.DG_Vendas.AllowUserToDeleteRows = false;
            this.DG_Vendas.AutoGenerateColumns = false;
            this.DG_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DG_Vendas.DataSource = this.itensVendaBindingSource;
            this.DG_Vendas.Location = new System.Drawing.Point(9, 185);
            this.DG_Vendas.Name = "DG_Vendas";
            this.DG_Vendas.ReadOnly = true;
            this.DG_Vendas.Size = new System.Drawing.Size(546, 134);
            this.DG_Vendas.TabIndex = 8;
            this.DG_Vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_Vendas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(95, 136);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.txt_quantidade.Location = new System.Drawing.Point(95, 103);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(121, 20);
            this.txt_quantidade.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txt_codigo.Location = new System.Drawing.Point(95, 26);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.codigoVendaTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataPagamento", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 410);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(286, 413);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 13);
            label1.TabIndex = 34;
            label1.Text = "Até que dia está alugado:";
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(667, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.CB_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.ComboBox CB_produto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView DG_Vendas;
        private System.Windows.Forms.Button btn_novoitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_valortotal;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox CB_pgto;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DateTimePicker txt_data_venc;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}