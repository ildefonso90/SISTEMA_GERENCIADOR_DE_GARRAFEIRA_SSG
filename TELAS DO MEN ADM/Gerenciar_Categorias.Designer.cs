namespace $safeprojectname$
{
    partial class Gerenciar_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar_Categorias));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINS_GARRAFEIRADataSet1 = new $safeprojectname$.LOGINS_GARRAFEIRADataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Label();
            this.bt_Excluir = new System.Windows.Forms.Label();
            this.bt_imprimir = new System.Windows.Forms.Label();
            this.bt_Casdastrar = new System.Windows.Forms.Label();
            this.bt_novo = new System.Windows.Forms.Label();
            this.tBL_CategoriaTableAdapter = new $safeprojectname$.LOGINS_GARRAFEIRADataSet1TableAdapters.TBL_CategoriaTableAdapter();
            this.nomeLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINS_GARRAFEIRADataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nomeCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLCategoriaBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Categoria";
            resources.ApplyResources(this.idCategoriaDataGridViewTextBoxColumn, "idCategoriaDataGridViewTextBoxColumn");
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCategoriaDataGridViewTextBoxColumn
            // 
            this.nomeCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Categoria";
            resources.ApplyResources(this.nomeCategoriaDataGridViewTextBoxColumn, "nomeCategoriaDataGridViewTextBoxColumn");
            this.nomeCategoriaDataGridViewTextBoxColumn.Name = "nomeCategoriaDataGridViewTextBoxColumn";
            // 
            // tBLCategoriaBindingSource
            // 
            this.tBLCategoriaBindingSource.DataMember = "TBL_Categoria";
            this.tBLCategoriaBindingSource.DataSource = this.lOGINS_GARRAFEIRADataSet1;
            // 
            // lOGINS_GARRAFEIRADataSet1
            // 
            this.lOGINS_GARRAFEIRADataSet1.DataSetName = "LOGINS_GARRAFEIRADataSet1";
            this.lOGINS_GARRAFEIRADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Name = "label9";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Name = "label6";
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bt_voltar, "bt_voltar");
            this.bt_voltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_voltar.Name = "bt_voltar";
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bt_Excluir, "bt_Excluir");
            this.bt_Excluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Excluir.Name = "bt_Excluir";
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bt_imprimir, "bt_imprimir");
            this.bt_imprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_imprimir.Name = "bt_imprimir";
            // 
            // bt_Casdastrar
            // 
            this.bt_Casdastrar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bt_Casdastrar, "bt_Casdastrar");
            this.bt_Casdastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Casdastrar.Name = "bt_Casdastrar";
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bt_novo, "bt_novo");
            this.bt_novo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_novo.Name = "bt_novo";
            // 
            // tBL_CategoriaTableAdapter
            // 
            this.tBL_CategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // nomeLogin
            // 
            this.nomeLogin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.nomeLogin, "nomeLogin");
            this.nomeLogin.ForeColor = System.Drawing.Color.Black;
            this.nomeLogin.Name = "nomeLogin";
            // 
            // Gerenciar_Categorias
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nomeLogin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_Casdastrar);
            this.Controls.Add(this.bt_novo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Gerenciar_Categorias";
            this.Load += new System.EventHandler(this.Gerenciar_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINS_GARRAFEIRADataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bt_voltar;
        private System.Windows.Forms.Label bt_Excluir;
        private System.Windows.Forms.Label bt_imprimir;
        private System.Windows.Forms.Label bt_Casdastrar;
        private System.Windows.Forms.Label bt_novo;
        private LOGINS_GARRAFEIRADataSet1 lOGINS_GARRAFEIRADataSet1;
        private System.Windows.Forms.BindingSource tBLCategoriaBindingSource;
        private LOGINS_GARRAFEIRADataSet1TableAdapters.TBL_CategoriaTableAdapter tBL_CategoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label nomeLogin;
    }
}