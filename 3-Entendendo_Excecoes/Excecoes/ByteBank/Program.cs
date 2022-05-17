namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.Nome = "Gabriela";
            gabriela.CPF = "095.983.878.95";
            gabriela.Profissao = "Dev";

            Cliente lucas = new Cliente();

            lucas.Nome = "Lucas";
            lucas.CPF = "100.965.456.32";
            lucas.Profissao = "Dev";

            Cliente bruno = new Cliente();

            bruno.Nome = "Bruno";
            bruno.CPF = "999.126.402.22";
            bruno.Profissao = "Dev";


            ContaCorrente contaDaGabriela = new ContaCorrente(gabriela, 896, 1000, 10000);
            ContaCorrente contaDoBruno = new ContaCorrente(lucas, 402, 9005, 10000);
            ContaCorrente contaDoLucas = new ContaCorrente(bruno, 822, 3222, 10000);


            contaDaGabriela._titular = gabriela;
            contaDaGabriela._saldo = 500;
            contaDoBruno._saldo *= 500;



            Console.ReadLine();

        }

    }
}