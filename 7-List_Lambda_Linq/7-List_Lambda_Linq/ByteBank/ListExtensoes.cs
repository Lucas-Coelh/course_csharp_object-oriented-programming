namespace ByteBank
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void Imprimir<T>(this List<T> lista)
        {
            foreach (T item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
