using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace $safeprojectname$
{
    public partial class tela_de_login : Form
    {

       public static string nome = "";

        public tela_de_login()
        {
            InitializeComponent();
        }

        //conexao com o banco de dados
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Integrated security=true; Initial Catalog=LOGINS_GARRAFEIRA");
        //vamso instaciar o sql comand --- usar delete, insirt, update...
        SqlCommand cm = new SqlCommand();
        //vamso instaciar o sql DataReader --- para usarmos o select
        SqlDataReader dt;
        private void button1_Click(object sender, EventArgs e)
        {
            //isso pertence a parte do do butão sair
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string veirficar_user_ATD = "";
            string veirficar_user_ADM = "";
            //aqui criamos alguma variaveis para armazenarmos os valores das textboxs 
            string User = box_user.Text;
            string Pass = box_pass.Text;
            //aqui crie uma variavel para armazenar o nome vindo do banco de dados
           
            //fiz uma verificação para ver se nos textbox tem valores
            if (box_pass.Text == "" || box_user.Text == "")
            {
                //apresentamso uma caixa de mensagem
                MessageBox.Show("Campos vazios!!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    //Logica do banco de dados
                    //NA VERDADE E MUITO SIMPES PRIMEIRO ELE FAZ UMA CONSULTA A PROCURA DOS DADOS TEXTBOX1 E 2 SE ENCONTRAR ELE CAI
                    //PARA MINHA CONDIÇÃO QUE VERIFICA SE O DADO PASSADO NO TEXTBOX CORESPONDE AO DADO CONSULTADO NO BANCO DE DADOS SE FOR
                    //SE FOR QUALQUER DADO CONSULTADO NA LINHA EXPECIFICA ELLE DA UM TRUE SE NÃO UM FALSE ---- SIMPLES NÃO????
                    cn.Open();
                    cm.CommandText = "select * from TBL_LOGIN_ATD where SENHA_ATD = ('" + Pass + "')and USUARIO_ATD = ('" + User + "')";
                    //     cm.CommandText = "select * from TBL_LOGIN_ADM where SENHA_ADM = ('" + Pass + "')and USUARIO_ADM = ('" + User + "')";
                    //estamos a dizer q a instaciar a cer iniciada é a conexão
                    cm.Connection = cn;
                    //estamos a exeuctar a instancia do comand select pois esse é a função do reader
                    dt = cm.ExecuteReader();
                    //agora vamos fazer uma verificação para vermos e os campos estão vazios
                    if (dt.Read())
                    {
                        //estava dando erro dando erro >>>>>>>
                        //fizemos uma cosulta bem simples trazendo apenas o nome da linha filtrada pela pass e user
                        nome = dt["NOME_ATD"].ToString();
                        veirficar_user_ATD = dt["USUARIO_ATD"].ToString();
                    }
                    if (!dt.HasRows) //dt.HasRows ---- no caso ele diz se nao fororam encontrados na tabela atendente então vericada na ADM               
                    {
                        cm.CommandText = "select * from TBL_LOGIN_ADM where SENHA_ADM = ('" + Pass + "')and USUARIO_ADM = ('" + User + "')";
                        dt.Close();
                        dt = cm.ExecuteReader();
                        if (dt.Read())
                        {
                            //estava dando erro dando erro >>>>>>>
                            //fizemos uma cosulta bem simples trazendo apenas o nome da linha filtrada pela pass e user
                            nome = dt["NOME_ADM"].ToString();
                            veirficar_user_ADM = dt["USUARIO_ADM"].ToString();
                        }
                    }
                        bool saoiguais_ATD = (veirficar_user_ATD == User);
                        bool saoiguais_ADM = (veirficar_user_ADM == User);
                        if (dt.HasRows && saoiguais_ATD)
                        {
                            MessageBox.Show("Bem vindo atendente " + nome, "entrou", MessageBoxButtons.OK);
                            Menu_atendente menu_atd = new Menu_atendente();
                            menu_atd.Show();
                            //em de usarmos o close ou talvez exit usamos o hide para ocultar o form principal pois se usarmos um close o programa fecha
                            this.Hide();
                        }

                        else if (dt.HasRows && saoiguais_ADM)
                        {
                            MessageBox.Show("Bem vindo Administrador " + nome, "entrou", MessageBoxButtons.OK);
                            Passagem_ADM p_Adm = new Passagem_ADM();
                            p_Adm.Show();
                            //em de usarmos o close ou talvez exit usamos o hide para ocultar o form principal pois se usarmos um close o programa fecha
                            this.Hide();
                        }
                        else
                        {
                            //apresentamso uma caixa de mensagem
                            MessageBox.Show("pass ou user erado");
                            //aqui limpamos as texbox depois do erro na pass ou user
                            box_pass.Clear();
                            box_user.Clear();
                            //aqui vamos focar cursor no textbox 
                            box_user.Focus();
                        }
                }
                // aque é no caso de algo dar errado o catch (Exception erro) guarda o erro denrto do string error ou erro
                catch (Exception error)
                {
                    //apresentamso uma caixa de mensagem dizendo o erro vericado
                    MessageBox.Show("" + error);
                    //fechamos a conexão com o banco de dabos
                    cn.Close();
                    //aqui limpamos as texbox depois do erro
                    box_pass.Clear();
                    box_user.Clear();
                    box_user.Focus();
                }
                //finalizamos a conexão com o banco de dabos
                finally
                {
                    //finalizamos a conexão com o banco de dabos
                    cn.Close();
                }

            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //esta parte serve para não permitir o redimensionameto
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //desativar o butun fechar
            this.MaximizeBox = false;
            //essa parte serve para difinir o tamanho maximo e minimo da tela ou seja o tamanho fixo
            this.MaximumSize = new Size(800, 600);
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
                    }
    }
}
