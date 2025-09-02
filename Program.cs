public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");

        Televisao tv = new Televisao(55f);

        Console.WriteLine($"A Tv tem o tamanho{tv.Tamanho}");
    }
