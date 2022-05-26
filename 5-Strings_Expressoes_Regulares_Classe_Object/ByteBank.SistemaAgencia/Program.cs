using ByteBank.Modelos;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Guilherme";
            cliente1.CPF = "123.456.789-10";
            cliente1.Profissao = "Desenvolvedor";

            Console.WriteLine(cliente1.ToString());

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Gabriel";
            cliente2.CPF = "987.654.321-09";
            cliente2.Profissao = "Desenvolvedor";
            
            Console.WriteLine(cliente2.ToString());

            //equals objects
            if (cliente1.Equals(cliente2))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("São diferentes");
            }
            


            Console.ReadLine();






            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";


            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Me ligue em 4002-8922";


            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Console.ReadLine();

            //-------------------------------------------------------//

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("/cambio"));

            Console.WriteLine(urlTeste.Contains("https://www.bytebank.com"));

            Console.WriteLine(urlTeste.Contains("ByteBank"));



            Console.ReadLine();

            // pagina?argumentos
            // 012345678



            //moedaOrigem=real&moedaDestino=dolar
            //                             |
            //            ----------------´


            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            //Testando ToUpper and ToLower
            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(termoBusca.ToLower());


            //Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);


            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));


            Console.ReadLine();

            //-------------------------------------------------------//

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            Console.WriteLine($"Valor de moedaDestino: " + extratorDeValores.GetValor("moedaDestino"));

            Console.WriteLine($"Valor de moedaOrigem: " + extratorDeValores.GetValor("moedaOrigem"));

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();

            //-------------------------------------------------------//

            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            Console.ReadLine();

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();





            //// Testando o IsNullOrEmpty
            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "kjhfsdjhgsdfjksdf";
            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();






            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);


            Console.ReadLine();
        }


    }


}