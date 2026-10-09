using System;
using System.Linq;

namespace ScreenSound.Modelos;

public class Podcast
{

    private List<Episodio> episodios = new List<Episodio>();

    // Construtor
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}; Apresentador: {Host}\n");

        foreach (var episodio in episodios.OrderBy(ep => ep.Ordem))
        {
            Console.WriteLine($"Episódio {episodio.Ordem}: {episodio.Titulo}");
        }

            Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
    }
}

