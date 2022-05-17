namespace _01_ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDoLucas = new ContaCorrente();

            
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 888;
            contaDaGabriela.numero = 835425;
            contaDaGabriela.saldo = 100000;

            contaDoBruno.titular = "Bruno";
            contaDoBruno.agencia = 888;
            contaDoBruno.numero = 888888;
            contaDoBruno.saldo = 1200;

            Console.WriteLine("Nome: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: "+contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            contaDaGabriela.saldo += 100;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            


            


            Console.ReadLine();

        }

    }
}