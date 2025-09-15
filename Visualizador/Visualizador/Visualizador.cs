using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador
{

    public partial class w_Visualizador : Form
    {
        public w_OptionsForm[] propriedades;
        public w_Visualizador()
        {
            InitializeComponent();
            propriedades = new w_OptionsForm[3];
            int i;

            for (i = 0; i < 3; i++)
            {
                propriedades[i] = new w_OptionsForm();
                if (i == 0)
                {
                    propriedades[i].BackColor = Color.Red;

                    propriedades[i].Left = 50;
                }
                else if (i == 1)
                {
                    propriedades[i].BackColor = Color.Green;

                    propriedades[i].Left = 1000;
                }
                else if (i == 2)
                {
                    propriedades[i].BackColor = Color.Blue;

                    propriedades[i].Left = 500;
                }
            }
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Figura.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
          }

        private void btn_Aumentar_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 20;
            this.Height = this.Height + 20;
            btn_Selecionar.Left += 20;
            btn_Fechar.Left += 20;
            btn_Aumentar.Left += 20;
            btn_Aumentar.Top += 20;
            btn_Diminuir.Left += 20;
            btn_Diminuir.Top += 20;
            btnDrawBorder.Left += 20;
            lblX.Left += 20;
            lblY.Left += 20;
            pb_Figura.Width += 20;
            pb_Figura.Height += 20;
        }

        private void btn_Diminuir_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 20;
            this.Height = this.Height - 20;
            btn_Selecionar.Left -= 20;
            btn_Fechar.Left -= 20;
            btn_Aumentar.Left -= 20;
            btn_Aumentar.Top -= 20; 
            btn_Diminuir.Left -= 20;
            btn_Diminuir.Top -= 20;
            btnDrawBorder.Left -= 20;
            lblX.Left -= 20;
            lblY.Left -= 20;
            pb_Figura.Width -= 20;
            pb_Figura.Height -= 20;
        }

        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            Graphics objGraphics = null; objGraphics = this.CreateGraphics();
            objGraphics.Clear(SystemColors.Control);
            objGraphics.DrawRectangle(Pens.Blue,
            pb_Figura.Left - 1, pb_Figura.Top - 1,
            pb_Figura.Width + 1, pb_Figura.Height + 1); 
        }

        private void pb_Figura_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " +e.X.ToString();
            lblY.Text = "Y: " +e.Y.ToString();
        }

        private void pb_Figura_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "X: ";
            lblY.Text = "Y: ";
        }

        private void pb_Figura_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lblX.Text = "X: ";
            lblY.Text = "Y: ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void w_Visualizador_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btn_Janela_Click(object sender, EventArgs e)
        {
            propriedades.ShowDialog();
        }

        private void w_Visualizador_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
