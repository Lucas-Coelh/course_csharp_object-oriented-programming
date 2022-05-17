class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 -  Caracteres e Textos");

        char letra = 'b';
        Console.WriteLine(letra);

        char letra2 = (char) 66 ;
        Console.WriteLine(letra2);

        char letra3= (char) (66+10);
        Console.WriteLine(letra3);


        char vazio = ' '; // Não pode ficar vazia, precisa de pelo menos um espaço para funcionar
        string vazia = ""; // Pode ficar vazio

        string cursos = @"Cursos disponiveis na Alura: 
- C# 
- Java 
- GO 
- Python ";
        Console.WriteLine(cursos);


        string primeiraFrase = "Alura - Cursos de tecnologia " + letra3;

        Console.WriteLine(primeiraFrase);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}