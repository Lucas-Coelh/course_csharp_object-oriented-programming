using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(45, 46, 2, 1, 51, 15);

            for (int i = 0; i < idades.Tamanho; i++)
            {
                Console.WriteLine(idades[i]);

            }

            Console.ReadLine();




           
        }
        
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.AdicionarVarios(56, 6, 9, 4, 45, 65, 85, 98, 78);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i} = {idade}");
            }
            @object contaDoLucas = new @object(111, 11111111);

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.AdicionarVarios(
               contaDoLucas,
               new @object(123, 12345678),
               new @object(456, 45645678),
               new @object(789, 78945678),
               new @object(111, 11111111),
               new @object(123, 12345678),
               new @object(456, 45645678),
               new @object(789, 78945678)
               );

            for (int i = 0; i < lista.Tamanho; i++)
            {

                Console.WriteLine($"Conta na posição {i} = {lista[i]}");
            }

            Console.ReadLine();

            lista.EscreverListaNaTela();

            lista.Remover(contaDoLucas);

            Console.WriteLine("\n\n\n");

            lista.EscreverListaNaTela();

            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            //array de ContaCorrente
            object[] contas = new object[]
            {
                new object(874,874654),
                new object(874, 874654),
                new object(874, 874654)
            };


        }

        static void TestaArrayInt()
        {
            int[] idades = new int[5];
            int idadeIndice4;

            //calcular media das idades
            int soma = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Digite a idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                soma += idades[i];
            }
            double media = soma / idades.Length;
            Console.WriteLine($"A média das idades é: {media}");

            idadeIndice4 = idades[4];
        }


    }
}
