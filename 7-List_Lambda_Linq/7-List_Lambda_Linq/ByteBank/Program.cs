namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(2);
            idades.Add(3);
            idades.Add(4);
            idades.Add(5);
            idades.Add(6);

            idades.AdicionarVarios(new int[] { 7, 8, 9, 10, 11, 12 });

            idades.Remove(11);
            
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);

            }

            Console.ReadLine();





        }

    }
}
