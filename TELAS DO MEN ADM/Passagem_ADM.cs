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
    public partial class Passagem_ADM : Form
    {
        public Passagem_ADM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Adm M_adm = new Menu_Adm();
            M_adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_atendente menu_atd = new Menu_atendente();
            menu_atd.Show();
        }
    }
}
