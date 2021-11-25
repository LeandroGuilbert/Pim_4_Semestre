
namespace Sistema
{
    partial class frm_cliente
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label cPFLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cliente));
            this.bd_sistemaDataSet = new Sistema.bd_sistemaDataSet();
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new Sistema.bd_sistemaDataSetTableAdapters.tb_clienteTableAdapter();
            this.tableAdapterManager = new Sistema.bd_sistemaDataSetTableAdapters.TableAdapterManager();
            this.tb_clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.tb_clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingNavigator)).BeginInit();
            this.tb_clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(25, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(13, 90);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 116);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(13, 142);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 7;
            celularLabel.Text = "Celular:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(13, 169);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(13, 194);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 11;
            cPFLabel.Text = "CPF:";
            // 
            // bd_sistemaDataSet
            // 
            this.bd_sistemaDataSet.DataSetName = "bd_sistemaDataSet";
            this.bd_sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteBindingSource
            // 
            this.tb_clienteBindingSource.DataMember = "tb_cliente";
            this.tb_clienteBindingSource.DataSource = this.bd_sistemaDataSet;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = this.tb_clienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema.bd_sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_clienteBindingNavigator
            // 
            this.tb_clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_clienteBindingNavigator.BindingSource = this.tb_clienteBindingSource;
            this.tb_clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_clienteBindingNavigatorSaveItem});
            this.tb_clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_clienteBindingNavigator.Name = "tb_clienteBindingNavigator";
            this.tb_clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_clienteBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tb_clienteBindingNavigator.TabIndex = 0;
            this.tb_clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_clienteBindingNavigatorSaveItem
            // 
            this.tb_clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_clienteBindingNavigatorSaveItem.Image")));
            this.tb_clienteBindingNavigatorSaveItem.Name = "tb_clienteBindingNavigatorSaveItem";
            this.tb_clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(94, 22);
            this.tb_clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_clienteBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(61, 61);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(61, 87);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(61, 113);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(61, 139);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(200, 20);
            this.celularTextBox.TabIndex = 8;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_clienteBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(61, 165);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(61, 191);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPFTextBox.TabIndex = 12;
            // 
            // tb_clienteDataGridView
            // 
            this.tb_clienteDataGridView.AllowUserToAddRows = false;
            this.tb_clienteDataGridView.AllowUserToDeleteRows = false;
            this.tb_clienteDataGridView.AutoGenerateColumns = false;
            this.tb_clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tb_clienteDataGridView.DataSource = this.tb_clienteBindingSource;
            this.tb_clienteDataGridView.Location = new System.Drawing.Point(28, 290);
            this.tb_clienteDataGridView.Name = "tb_clienteDataGridView";
            this.tb_clienteDataGridView.ReadOnly = true;
            this.tb_clienteDataGridView.Size = new System.Drawing.Size(750, 253);
            this.tb_clienteDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn4.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn6.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 220);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_clienteDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(this.tb_clienteBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingNavigator)).EndInit();
            this.tb_clienteBindingNavigator.ResumeLayout(false);
            this.tb_clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_sistemaDataSet bd_sistemaDataSet;
        private System.Windows.Forms.BindingSource tb_clienteBindingSource;
        private bd_sistemaDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private bd_sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.DataGridView tb_clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}