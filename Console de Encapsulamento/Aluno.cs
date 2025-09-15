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
        private string nome;
        private static double NotaAprov = 6.0;
        public static int Gerador = 0;
        private double Nota1, Nota2, Nota3;
        private double Media;

        public string Nome {  get; set; }

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

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public static double GetNotaAprov()
        {
            return NotaAprov;
        }

        public void SetNota1(int nota1)
        {
            this.Nota1 = nota1;
        }
        public void SetNota2(int nota2)
        {
            this.Nota2 = nota2;
        }
        public void SetNota3(int nota3)
        {
            this.Nota3 = nota3;
        }

        public double GetNota1() { return Nota1; }
        public double GetNota2() { return Nota2; }
        public double GetNota3() { return Nota3; }

        public double GetMedia(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}