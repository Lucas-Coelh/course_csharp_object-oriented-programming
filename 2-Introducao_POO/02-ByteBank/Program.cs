namespace _02_ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDoLucas = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);


            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Tranferir(56, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);





            Console.ReadLine();

        }

    }
}