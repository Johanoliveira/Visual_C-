using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaApp
{
    internal class Contas
    {
        public class Conta
        {
            public string Nome { get; set; }
            public double Saldo { get; private set; }
            public double Limite { get; set; }

            public Conta(string nome, double saldo, double limite)
            {
                Nome = nome;
                Saldo = saldo;
                Limite = limite;
            }

            public void Deposita(double valor)
            {
                Saldo += valor;
            }

            public void Saca(double valor)
            {
                if (valor > Saldo + Limite)
                {
                    //message box
                    throw new InvalidOperationException("Saldo insuficiente com limite.");
                }
                Saldo -= valor;
            }

            public double Consulta()
            {
                return Saldo;
            }
        }
    }
}