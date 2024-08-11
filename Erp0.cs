using AngleSharp.Text;
using ERP.objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Erp0 : Form
    {
        public Erp0(string logado)
        {
            InitializeComponent();
            Logado = logado; 

        }
        private string Logado {  get; set; }
        string[] _logado;
        private void Erp0_FormClosed(object sender, FormClosedEventArgs e)
        {
            string dlog;
            int log;
            Usuario usuario = new Usuario();
            _logado = Logado.Split(' ');
            dlog = _logado[0].Trim();
            log = int.Parse(dlog);

            usuario.Deslogar(log);

            Application.Exit();
        }

        private void Erp0_Load(object sender, EventArgs e)
        {
            slogado.Text = Logado;             
        }
    }
}
