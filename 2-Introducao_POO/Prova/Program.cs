namespace _03_ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            int n1, n2, r = 2, final = 1;
            Console.WriteLine("Digite dois números inteiros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            while (n1 > 1 || n2 > 1)
            {
                if ((n1 % r == 0) && (n2 % r == 0))
                {
                    final = final * r;
                    n1 = n1 / r;
                    n2 = n2 / r;
                }
                else
                {
                    if ((n1 % r == 0))
                    {
                        final = final * r;
                        n1 = n1 / r;
                    }
                    else
                    {
                        if ((n2 % r == 0))
                        {
                            final = final * r;
                            n2 = n2 / r;
                        }
                        else
                            r++;
                    }
                }
                Console.WriteLine(n1 + ", " + n2 + " | " + r);
            }
            Console.WriteLine("Final: " + final);
            Console.ReadKey();
        }
    }
}




