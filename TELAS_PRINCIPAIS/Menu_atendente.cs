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
    public partial class Menu_atendente : Form
    {
        public Menu_atendente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Tela_RegistrarVenda RegistrarVenda = new Tela_RegistrarVenda();
            RegistrarVenda.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tela_ConsultarEstoque ConsultarEstoque = new Tela_ConsultarEstoque();
            ConsultarEstoque.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Tela_Recibo Recibo = new Tela_Recibo();
            Recibo.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Tela_HistoricodeVenda HistoricodeVenda = new Tela_HistoricodeVenda();
            HistoricodeVenda.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //essa parte usamos a caixa de diaalogo para recebermos ua confirmaao se de sair ou não
          DialogResult resultadosair = MessageBox.Show("SAIR? Voçe deseja fechar o aplicativo?","Cnfirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //aqui pegamos o resuldado q guardamos no resair e dizemos se for sim para ele fechar todas janelas
            if (resultadosair == DialogResult.Yes)
            {
                //essa parte do codigo serve para fechar todas as janelas abertas do programa --- primeiro ela lista todas janelas abertas do programa
                //depois a parte do from.close serve para fechar todas
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {

                    form.Close();
                }
            }
        }

        private void Menu_atendente_Load(object sender, EventArgs e)
        {

        }
    }
}
