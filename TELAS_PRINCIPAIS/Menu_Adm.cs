using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Menu_Adm : Form
    {
        
        public Menu_Adm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_produtos_ADM Gere_P = new Cadastrar_produtos_ADM();
            Gere_P.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Gerenciar_Categorias ger_cat = new Gerenciar_Categorias();
            ger_cat.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Essa parte serve para abrirmos atela Gerenciar_Usuarios
            Gerenciar_Usuarios Gere_user = new Gerenciar_Usuarios();
            Gere_user.Show();
            this.Close();
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Adm_Load(object sender, EventArgs e)
        {
            //Essa parte serve para mostrar o nome do usuario logado
            nomeLogin.Text = tela_de_login.nome;
        }

      
    }
}
