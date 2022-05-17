class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 -  Calcula Poupança While");

        double investimento = 1000;

        //rendimento de 0.5% ao mês

        
        int mes = 1;

        while (mes <= 12)
        {
            investimento *= 1.005;
            Console.WriteLine($"No mes {mes} voce tem " + (int)investimento);
            
            mes++;

        }


        

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}