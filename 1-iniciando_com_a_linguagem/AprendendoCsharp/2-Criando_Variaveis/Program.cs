class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 -  Criando Variáveis");


        int idade = 0;
        double salario = 78000.98, idade2;

        idade2 = (double) 7 / 5;//cast

        idade = 10+32;
        Console.WriteLine($"Minha idade é {idade}");
        Console.WriteLine($"Meu salario será {salario} doláres");

        Console.WriteLine($"Minha idade foi a muito tempo {idade2}");


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}