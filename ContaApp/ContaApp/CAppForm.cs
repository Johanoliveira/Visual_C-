using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContaApp.Contas;

namespace ContaApp
{
    public partial class w_ContaApp : Form
    {
        private Conta Conta;

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
            this.Saldo += valor;
        }

        public void saca(double valor)
        {
            this.Saldo -= valor;
        }

        public double consulta()
        {
            return this.Saldo;
        }

        public w_ContaApp()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSaldo.Text == "" || txtLimite.Text == "")
            {
                MessageBox.Show("Informe valores de nome, saldo e limite da conta!");
            }
            else
            {
                Conta = new Conta(txtNome.Text, Double.Parse(txtSaldo.Text), Double.Parse(txtLimite.Text));
                txtNome.ReadOnly = true;
                txtSaldo.ReadOnly = true;
                txtLimite.ReadOnly = true;
                MessageBox.Show("Conta criada com sucesso!");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if(txtValor.Text == "")
            {
                MessageBox.Show("Informe valor da operação!");
            }
            else
            {
                Conta.Saca(Double.Parse(txtValor.Text));
                txtValor.Text = "";
                txtSaldo.Text = Conta.Consulta().ToString();
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if(txtValor.Text == "")
            {
                MessageBox.Show("Informe o valor da operação!");
            }
            else
            {
                Conta.Deposita(Double.Parse(txtValor.Text));
                txtValor.Text = "";
                txtSaldo.Text = Conta.Consulta().ToString();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo atual: " + Conta.Consulta().ToString());
        }
    }
}
