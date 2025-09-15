using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaApp
{
    public partial class w_ContaApp : Form
    {
        public string Nome {  get; set; }
        public double Saldo { get; set; }  
        public double Limite { get; set; }

        public w_ContaApp(string nome, double saldo, double limite)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Limite = limite;
        }

        public void deposita(double valor)
        {

        }

        public w_ContaApp()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {

        }
    }
}
