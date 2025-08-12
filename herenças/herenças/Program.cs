namespace herenças
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" == ser vivo == ");
            SerVivo sv = new SerVivo();
            sv.Nascer();
            sv.Crescer();
            sv.Comer();
            Console.WriteLine(" == animal == ");
            Animal a = new Animal();
            a.Nascer();
            a.Dormir();
            a.Respirar();
        }
    }
}
