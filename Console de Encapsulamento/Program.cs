using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_de_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Al1 = new Aluno("Johan");
            Aluno Al2 = new Aluno("Tavares");

            Console.WriteLine("Nota de Aprovação: " + Aluno.GetNotaAprov());

            Console.WriteLine("Prontuário: " + Al1.GetProntuario());
            Console.WriteLine("Nome: " + Al1.GetNome());

            Console.WriteLine("Prontuário: " + Al2.GetProntuario());
            Console.WriteLine("Nome: " + Al2.GetNome());

            Al1.SetNota1(7);
            Al1.SetNota2(10);
            Al1.SetNota3(5);

            Console.WriteLine("A média do aluno com as seguintes notas: " + Al1.GetNota1() + ", " + Al1.GetNota2() + ", " + Al1.GetNota3() + " é igual a: " + Al1.GetMedia(Al1.GetNota1(), Al1.GetNota2(), Al1.GetNota3()));

            Console.ReadLine();
        }
    }
}
