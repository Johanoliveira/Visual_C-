using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_de_uma_pessoa___atv_acompanhamento
{
    public partial class w_IMCForm : Form
    {
        public w_IMCForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float peso, altura, imc;
            if (txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Preencha a altura e o peso!");
            }
            else
            {
                peso = float.Parse(txtPeso.Text);
                altura = float.Parse(txtAltura.Text);
                imc = peso / (altura * altura);
                lblResultado.Text = $"IMC = {imc:0.00}";
                if (imc < 18.5) lblAnalise.Text = "Abaixo do Peso";
                else if (imc < 25) lblAnalise.Text = "Peso Saudável";
                else if (imc < 30) lblAnalise.Text = "Sobrepeso";
                else if (imc < 35) lblAnalise.Text = "Obsidade Grau I";
                else if (imc < 40) lblAnalise.Text = "Obsidade Grau II";
                else lblAnalise.Text = "Obsidade Mórbida";
            }
        }

        private void w_IMCForm_Load(object sender, EventArgs e)
        {
        }
    }
}
