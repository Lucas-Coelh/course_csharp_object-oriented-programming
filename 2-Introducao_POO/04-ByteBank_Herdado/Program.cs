using _04_ByteBank_Herdado.Funcionarios;
using _04_ByteBank_Herdado.Sistemas;

namespace _04_ByteBank_Herdado
{
    class Program
    {

        static void Main(string[] args)
        {
            UsarSistema();


            Console.ReadLine();


        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();


            Diretor lais = new Diretor("Lais", 0, "044.654.455.24");
            GerenteDeConta guilherme = new GerenteDeConta("Guilherme", 0, "001.007.296.23");
            ParceiroComercial douglas = new ParceiroComercial();


            lais.Senha = "ABC";
            guilherme.Senha = "123";
            douglas.Senha = "568";

            sistemaInterno.Logar(lais, "ABC");
            sistemaInterno.Logar(guilherme, "123");
            sistemaInterno.Logar(douglas, "568");


        }

    }
}