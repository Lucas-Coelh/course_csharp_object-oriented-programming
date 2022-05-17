class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 -  Calcula Poupança For");

        double investimento = 1000;

        //rendimento de 0.5% ao mês

       
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine($"No mes {mes} voce tem " + (int)investimento);

        }




        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}