using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Objetos
    ///
    ///tela de mensagem padrao
    ///

{
    internal class Configuracao
    {
        public string Path {  get; set; }

        public string Diretorio(string Path)
        {
            var dados = Program.cx.ExecutaSql("SELECT path FORM ini_sis WHERE path Is NOT NULL ");
            if (dados != null)
            {
                return Path;
            }
            return Path = dados.ToString();
        }

    }
}
