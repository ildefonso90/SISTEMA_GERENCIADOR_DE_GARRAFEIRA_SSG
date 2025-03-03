namespace $safeprojectname$
{
    partial class tela_de_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_de_login));
            this.box_user = new System.Windows.Forms.TextBox();
            this.box_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_user
            // 
            this.box_user.Location = new System.Drawing.Point(79, 181);
            this.box_user.Name = "box_user";
            this.box_user.Size = new System.Drawing.Size(124, 20);
            this.box_user.TabIndex = 0;
            // 
            // box_pass
            // 
            this.box_pass.Location = new System.Drawing.Point(79, 207);
            this.box_pass.Name = "box_pass";
            this.box_pass.PasswordChar = '*';
            this.box_pass.Size = new System.Drawing.Size(124, 20);
            this.box_pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(30, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(35, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // bt_sair
            // 
            this.bt_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_sair.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bt_sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sair.ForeColor = System.Drawing.Color.Black;
            this.bt_sair.Location = new System.Drawing.Point(47, 253);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_entrar.ForeColor = System.Drawing.Color.Black;
            this.bt_entrar.Location = new System.Drawing.Point(128, 253);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(75, 23);
            this.bt_entrar.TabIndex = 5;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tela_de_login
            // 
            this.AcceptButton = this.bt_entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bt_sair;
            this.ClientSize = new System.Drawing.Size(599, 299);
            this.ControlBox = false;
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_pass);
            this.Controls.Add(this.box_user);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tela_de_login";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_user;
        private System.Windows.Forms.TextBox box_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_entrar;
    }
}

