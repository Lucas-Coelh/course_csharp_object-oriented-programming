using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            var contas = new List<ContaCorrente>()
            {
                null,
                new ContaCorrente(347, 10),
                new ContaCorrente(347, 99),
                new ContaCorrente(347, 88),
                null,
                null,
                new ContaCorrente(345, 22),
                null,
                new ContaCorrente(343, 23),
                new ContaCorrente(344, 32)

            };

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.NumeroAgencia}");
            }

            Console.ReadLine();


            var nomes = new List<string>()
            {
                "Zumabin",
                "Hillary",
                "Lady",
                "Lucas",
                "Larissa",
                "Amanda"

            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(5);
            idades.Add(10);
            idades.Add(15);
            idades.Add(20);

            idades.AdicionarVarios(45, 32, 33, 56, 23);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }


            Console.ReadLine();





        }


    }
}
