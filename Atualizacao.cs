using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    /// <summary>
    /// Tela responsavel pela checagem de arquivo .sql
    /// para efetuar a atualizacao do sistema
    /// estara faltando nome do sistema e logo 
    /// </summary>
    public partial class Atualizacao : Form
    {
        public Atualizacao()
        {
            InitializeComponent();
        }

        Msg msg = new Msg();
        Login login = new Login();

        private async void Atualizacao_Load(object sender, EventArgs e)
        {
            ///variavel de uso para o metodo///
            string path ,
                   erro = "";
            string[] arquivos;

            if (Program.cx.testarConexao())
            {
                var dados = Program.cx.ExecutaSql("SELECT path FROM ini_sis");
                if (dados != null)
                {
                    DataRow linhaDados = dados.Rows[0];
                    path = linhaDados["path"].ToString();

                    try
                    {
                        arquivos = Directory.GetFiles(path, "*.SQL");

                        if (arquivos.Length == 0 )
                        {
                            pbatl.Value = 0;
                            latl.Text = "(" + " Iniciando sistema " + ")";
                            for(int i=0; i <= pbatl.Maximum; i++)
                            {
                                pbatl.Value = i;
                                await Task.Delay(5); // Aguarda 2 segundos sem bloquear a UI
                            }
                        }
                        else
                        {
                            latl.Text = "(" + " Verificando arquivos para atualização " + ")";
                            await Task.Delay(2000); // Aguarda 2 segundos sem bloquear a UI

                            pbatl.Maximum = arquivos.Length;

                            foreach (string arquivo in arquivos)
                            {
                                await Task.Delay(2000); // Aguarda 1 segundo sem bloquear a UI
                                arquivo.Split('/');

                                // Lê e executa o script SQL
                                string[] linhas = File.ReadAllLines(arquivo);
                                foreach (string linha in linhas)
                                {
                                    latl.Text = "(" + linha + ")";
                                    Program.cx.ExecutaSql(linha);
                                }
                                File.Delete(arquivo);
                            }
                            latl.Text = "(" + " Atualização realizada com sucesso " + ")";
                            await Task.Delay(2000); // Aguarda 2 segundos sem bloquear a UI
                        }
                    }
                    catch (Exception error)
                    {
                        // Exibe a mensagem de erro usando o formulário Msg
                        msg.Mensagem = error.Message;
                        msg.ShowDialog(); // Exibe o formulário de mensagem como um diálogo modal
                    }
                    AbrirFormLogin(); // Abre o formulário de login
                    this.Hide(); // Fecha o formulário de atualização
                }
                else
                {
                    msg.Mensagem = " Erro ao iniciar o sistema ";
                    msg.ShowDialog();
                    Application.Exit();
                }
            }
            else
            { 
                erro = Program.cx.getMsgErro();
                msg.Mensagem = erro;
                msg.ShowDialog();
                Application.Exit();
            }
        }
        private void AbrirFormLogin()
        {
            // Abre o formulário de login
            login.Show();

        }
    }
}
