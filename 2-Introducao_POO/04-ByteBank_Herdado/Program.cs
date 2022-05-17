using _04_ByteBank_Herdado.Funcionarios;

namespace _04_ByteBank_Herdado
{
    class Program
    {

        static void Main(string[] args)
        {
            CalcularBonificacao();
            
                        
            Console.ReadLine();

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Designer lucas = new Designer("Lucas", 0, "044.988.785.23");
            Diretor roberta = new Diretor("Roberta",0, "044.654.455.24");
            Auxiliar pedro = new Auxiliar("Pedro",0, "044.222.888.99");
            GerenteDeConta guilherme = new GerenteDeConta("Guilherme",0, "001.007.296.23");

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta); 
            gerenciadorBonificacao.Registrar(lucas);

            Console.WriteLine(gerenciadorBonificacao.GetTotalBonificacao());

            
        }
        
    }
}