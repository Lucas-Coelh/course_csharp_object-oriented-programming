using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 5, 22);
            DateTime dataCorrente = DateTime.Now;


            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine($"Tempo até o vencimento é de {TimeSpanHumanizeExtensions.Humanize(diferenca)}");

            Console.ReadLine();
        }

    }
}
