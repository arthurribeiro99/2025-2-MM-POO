public class Televisao
{
    public Televisao(float Tamanho)
    {
        Tamanho = Tamanho;
    }

    public float Tamanho { get; }
    public float Resolucao { get; set; }
    public float Volume { get; set; }
    public float Canal { get; set; }
    public float Estado { get; set; }

    public void AumentarVolume()
    {
        if (Volume < 100)
            Volume++;

        else
            Console.WriteLine("TV ja está no máximo.")
    }
} 