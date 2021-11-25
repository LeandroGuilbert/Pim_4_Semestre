
namespace Sistema
{
    partial class frm_checkin
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_checkin));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoPessoaComboBox = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigoPessoaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.DAL.Venda);
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoPessoaLabel.Location = new System.Drawing.Point(87, 35);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(85, 25);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // codigoPessoaComboBox
            // 
            this.codigoPessoaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.codigoPessoaComboBox.DataSource = this.pessoasBindingSource;
            this.codigoPessoaComboBox.DisplayMember = "Descricao";
            this.codigoPessoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoPessoaComboBox.FormattingEnabled = true;
            this.codigoPessoaComboBox.Location = new System.Drawing.Point(23, 63);
            this.codigoPessoaComboBox.Name = "codigoPessoaComboBox";
            this.codigoPessoaComboBox.Size = new System.Drawing.Size(219, 21);
            this.codigoPessoaComboBox.TabIndex = 2;
            this.codigoPessoaComboBox.ValueMember = "Codigo";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(sistema.DAL.Pessoas);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(53, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 25);
            label1.TabIndex = 5;
            label1.Text = "Dias Alugados:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(23, 156);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(53, 179);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 25);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Quarto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriaBindingSource;
            this.comboBox1.DisplayMember = "Descricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(sistema.DAL.Categoria);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(110, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "Até:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(53, 231);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 25);
            label4.TabIndex = 11;
            label4.Text = "Quarto Alugado";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.produtoBindingSource;
            this.comboBox2.DisplayMember = "Descricao";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Realizar Check-in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 307);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(sistema.DAL.Produto);
            // 
            // frm_checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.codigoPessoaComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_checkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Check-in";
            this.Load += new System.EventHandler(this.frm_checkin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox codigoPessoaComboBox;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}