using ERP.objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        Msg Msg = new Msg();
        Usuario login = new Usuario();
        string logado = "";
        private void Horas_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            string dh = dataHora.ToString();
            string[] DataHora = dh.Split(' ');
            l_data.Text = DataHora[0].Trim();
            l_horas.Text = DataHora[1].Trim();
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            Horas.Enabled = false;
            this.Close();
        }

        private void Bentrar_Click(object sender, EventArgs e)
        {
            
            if (Tbusuario.Text.Trim() == "" || Tbsenha.Text.Trim() == "")
            {
                Msg.Mensagem = "Usuário ou senha incorreta";
                Msg.Show();
            }
            else
            {
                login.Nome = Tbusuario.Text;
                login.Senha = Tbsenha.Text;

                if (login.Autenticar(login.Nome, login.Senha))
                {
                    Erp0 Erp = new Erp0(login.Logado(login.Nome));
                    Erp.Show();
                    Horas.Enabled = false;
                    this.Hide();
                }
                else
                {
                    Msg.Mensagem = "Usuário ou senha incorreta";
                    Msg.Show();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Tbusuario.Text = string.Empty;
            Tbsenha.Text = string.Empty;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Horas.Enabled = false;
            Application.Exit();
        }
    }
}
