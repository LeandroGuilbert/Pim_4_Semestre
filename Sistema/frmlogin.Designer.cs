
namespace Sistema
{
    partial class frmlogin
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(11, 41);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(92, 25);
            usuarioLabel.TabIndex = 1;
            usuarioLabel.Text = "Usuario:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.Location = new System.Drawing.Point(23, 88);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(80, 25);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataSource = typeof(sistema.DAL.tb_usuario);
            // 
            // txt_usuario
            // 
            this.txt_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "usuario", true));
            this.txt_usuario.Location = new System.Drawing.Point(109, 46);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(114, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "senha", true));
            this.txt_senha.Location = new System.Drawing.Point(109, 94);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(114, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(28, 142);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(99, 45);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.White;
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Location = new System.Drawing.Point(223, 142);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(99, 45);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 227);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_sair;
    }
}