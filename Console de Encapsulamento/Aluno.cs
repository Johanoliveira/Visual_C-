using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_de_Encapsulamento
{
    internal class Aluno
    {
        private int Prontuario;
        private string Nome;
        private static double NotaAprov = 6.0;  
        public static int Gerador = 0;
        private double Nota1, Nota2, Nota3;
        private double Media;

        public Aluno(string nome)
        {
            Aluno.Gerador++;
            this.Prontuario = Aluno.Gerador;
            this.Nome = nome;
        }

        public int GetProntuario()
        {
            return Prontuario;
        }

        public string GetNome()
        {
            return Nome;
        }

        public static double GetNotaAprov()
        {
            return NotaAprov;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetNota1(int nome)
        {
            this.Nota1 = nome;
        }
        public void SetNota2(int nome)
        {
            this.Nota2 = nome;
        }
        public void SetNota3(int nome)
        {
            this.Nota3 = nome;
        }

        public double GetNota1() { return Nota1;}
        public double GetNota2() { return Nota2; }
        public double GetNota3() { return Nota3; }

        private void SetMedia(double nota1, double nota2, double nota3) { }
    }
}
