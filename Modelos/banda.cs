namespace ScreenSound.Modelos;

public class Banda
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();

    public string Nome { get; set; } = string.Empty;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            return notas.Average();
        }
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} segundos.)");
        }
    }
}