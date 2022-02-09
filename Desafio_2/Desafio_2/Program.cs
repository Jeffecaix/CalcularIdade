using System;

namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = "Vinicius 06/12/89";

            string[] nomeData = data1.Split(" ");
            string nome = nomeData[0];

            DateTime dataCompleta = DateTime.Parse(nomeData[1]);
            DateTime dataAtual = DateTime.Parse("10/02/22");
            
            string CalculaIdadeDias(DateTime dataNascimento, DateTime dataAtual)
            {
                TimeSpan resultado = dataAtual - dataNascimento;
                return $"{nome} viveu até hoje {resultado.Days} dias.";
            }

            Console.WriteLine(CalculaIdadeDias(dataCompleta, dataAtual));           
            
        }
    }
}
