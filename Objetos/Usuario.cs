using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ERP.objetos
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public string Senha { get; set; }
        private string UserLogado { get; set; }
        public bool Valido { get; set; }

        string codibanco = "";

        //metodos
        public bool Autenticar(string Nome, string Senha)
        {

            Valido = false;
            var dados = Program.cx.ExecutaSql("SELECT * FROM usuario WHERE nome = '" + Nome + "' and SENHA = '" + Senha + "'");
 
            if(dados != null)
            {
                DataRow linhaDados = dados.Rows[0];
                string loginBanco = linhaDados["nome"].ToString();
                if (loginBanco == Nome)
                {
                    string senhaBanco = linhaDados["SENHA"].ToString();
                    if (senhaBanco == Senha)
                    {
                        Valido = true;
                    }
                }
            }
            return Valido;
        }
        public void Deslogar(int Codigo)
        {
            UserLogado = "N";
            var dadosl = Program.cx.ExecutaSql("UPDATE usuario SET logado ='" + UserLogado + "' WHERE CODIGO = '" + Codigo + "'");
        }

        public string Logado(string Nome)
        {
            string logado = "";
            var dados = Program.cx.ExecutaSql("SELECT * FROM usuario WHERE nome =  '" + Nome + "'" );

            DataRow linhaDados = dados.Rows[0];
            codibanco = linhaDados["CODIGO"].ToString();
            logado = (codibanco + " - " + linhaDados["NOME"].ToString());

            UserLogado = "S";
            var dadosl = Program.cx.ExecutaSql("UPDATE usuario SET logado ='" + UserLogado + "' WHERE codigo = '" + codibanco + "'");

            return logado;

        }
    }
}
