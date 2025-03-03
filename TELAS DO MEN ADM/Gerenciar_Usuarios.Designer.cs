namespace $safeprojectname$
{
    partial class Gerenciar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar_Usuarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbx_Senha = new System.Windows.Forms.TextBox();
            this.tbx_nome_usuario = new System.Windows.Forms.TextBox();
            this.bt_Tipo = new System.Windows.Forms.Label();
            this.cotbx_tipo = new System.Windows.Forms.ComboBox();
            this.bt_Senha = new System.Windows.Forms.Label();
            this.Nome_de_Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_excluir = new System.Windows.Forms.Label();
            this.bt_novo = new System.Windows.Forms.Label();
            this.bt_salvar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nomeLogin = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 210);
            this.dataGridView1.TabIndex = 20;
            // 
            // tbx_Senha
            // 
            this.tbx_Senha.Location = new System.Drawing.Point(424, 137);
            this.tbx_Senha.Name = "tbx_Senha";
            this.tbx_Senha.Size = new System.Drawing.Size(347, 20);
            this.tbx_Senha.TabIndex = 19;
            // 
            // tbx_nome_usuario
            // 
            this.tbx_nome_usuario.Location = new System.Drawing.Point(424, 111);
            this.tbx_nome_usuario.Name = "tbx_nome_usuario";
            this.tbx_nome_usuario.Size = new System.Drawing.Size(347, 20);
            this.tbx_nome_usuario.TabIndex = 18;
            // 
            // bt_Tipo
            // 
            this.bt_Tipo.AutoSize = true;
            this.bt_Tipo.BackColor = System.Drawing.Color.Transparent;
            this.bt_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_Tipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Tipo.Location = new System.Drawing.Point(377, 166);
            this.bt_Tipo.Name = "bt_Tipo";
            this.bt_Tipo.Size = new System.Drawing.Size(41, 18);
            this.bt_Tipo.TabIndex = 17;
            this.bt_Tipo.Text = "Tipo";
            // 
            // cotbx_tipo
            // 
            this.cotbx_tipo.FormattingEnabled = true;
            this.cotbx_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Atendente"});
            this.cotbx_tipo.Location = new System.Drawing.Point(424, 163);
            this.cotbx_tipo.Name = "cotbx_tipo";
            this.cotbx_tipo.Size = new System.Drawing.Size(347, 21);
            this.cotbx_tipo.TabIndex = 16;
            this.cotbx_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_Senha
            // 
            this.bt_Senha.AutoSize = true;
            this.bt_Senha.BackColor = System.Drawing.Color.Transparent;
            this.bt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_Senha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Senha.Location = new System.Drawing.Point(363, 139);
            this.bt_Senha.Name = "bt_Senha";
            this.bt_Senha.Size = new System.Drawing.Size(55, 18);
            this.bt_Senha.TabIndex = 15;
            this.bt_Senha.Text = "Senha";
            // 
            // Nome_de_Usuario
            // 
            this.Nome_de_Usuario.AutoSize = true;
            this.Nome_de_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Nome_de_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Nome_de_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nome_de_Usuario.Location = new System.Drawing.Point(344, 113);
            this.Nome_de_Usuario.Name = "Nome_de_Usuario";
            this.Nome_de_Usuario.Size = new System.Drawing.Size(72, 18);
            this.Nome_de_Usuario.TabIndex = 14;
            this.Nome_de_Usuario.Text = " Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(460, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gerenciar usuarios";
            // 
            // bt_excluir
            // 
            this.bt_excluir.AutoSize = true;
            this.bt_excluir.BackColor = System.Drawing.Color.Transparent;
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_excluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_excluir.Location = new System.Drawing.Point(62, 180);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(59, 18);
            this.bt_excluir.TabIndex = 22;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.AutoSize = true;
            this.bt_novo.BackColor = System.Drawing.Color.Transparent;
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_novo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_novo.Location = new System.Drawing.Point(62, 49);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(48, 18);
            this.bt_novo.TabIndex = 22;
            this.bt_novo.Text = "Novo";
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.AutoSize = true;
            this.bt_salvar.BackColor = System.Drawing.Color.Transparent;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_salvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_salvar.Location = new System.Drawing.Point(62, 110);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(55, 18);
            this.bt_salvar.TabIndex = 23;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(62, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Voltar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(271, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pesquisar Usuario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(424, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 20);
            this.textBox3.TabIndex = 26;
            // 
            // nomeLogin
            // 
            this.nomeLogin.BackColor = System.Drawing.Color.Transparent;
            this.nomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLogin.ForeColor = System.Drawing.Color.Black;
            this.nomeLogin.Location = new System.Drawing.Point(37, 493);
            this.nomeLogin.Name = "nomeLogin";
            this.nomeLogin.Size = new System.Drawing.Size(106, 26);
            this.nomeLogin.TabIndex = 27;
            this.nomeLogin.Text = "nomeLogin";
            this.nomeLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(424, 85);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(347, 20);
            this.tbx_nome.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(363, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            // 
            // Gerenciar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeLogin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbx_Senha);
            this.Controls.Add(this.tbx_nome_usuario);
            this.Controls.Add(this.bt_Tipo);
            this.Controls.Add(this.cotbx_tipo);
            this.Controls.Add(this.bt_Senha);
            this.Controls.Add(this.Nome_de_Usuario);
            this.Name = "Gerenciar_Usuarios";
            this.Text = "Gerenciar_Usuarios";
            this.Load += new System.EventHandler(this.Gerenciar_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbx_Senha;
        private System.Windows.Forms.TextBox tbx_nome_usuario;
        private System.Windows.Forms.Label bt_Tipo;
        private System.Windows.Forms.ComboBox cotbx_tipo;
        private System.Windows.Forms.Label bt_Senha;
        private System.Windows.Forms.Label Nome_de_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bt_excluir;
        private System.Windows.Forms.Label bt_novo;
        private System.Windows.Forms.Label bt_salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nomeLogin;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label2;
    }
}