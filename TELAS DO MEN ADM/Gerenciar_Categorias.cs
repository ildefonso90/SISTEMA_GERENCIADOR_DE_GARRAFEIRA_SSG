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
    public partial class Gerenciar_Categorias : Form
    {
        public Gerenciar_Categorias()
        {
            InitializeComponent();
        }

        private void Gerenciar_Categorias_Load(object sender, EventArgs e)
        {
            //Essa parte serve para mostrar o nome do usuario logado
            nomeLogin.Text = tela_de_login.nome;
        }
    }
}
