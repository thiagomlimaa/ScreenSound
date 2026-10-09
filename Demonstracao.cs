using ScreenSound.Modelos;

public static class Demonstracao
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("Demonstração: banda, álbum e podcast\n");

        Banda morada = new Banda();
        morada.Nome = "Morada";

        Album albumDoMorada = new Album();
        albumDoMorada.Nome = "Adoração";

        Musica musica1 = new Musica(morada);
        musica1.Nome = "Emaús";
        musica1.Duracao = 213;

        Musica musica2 = new Musica(morada);
        musica2.Nome = "Tudo Sobre Você";
        musica2.Duracao = 354;

        albumDoMorada.AddMusica(musica1);
        albumDoMorada.AddMusica(musica2);
        albumDoMorada.ExibirMusicaDoAlbum();

        morada.AdicionarAlbum(albumDoMorada);
        morada.ExibirDiscografia();

        Episodio episodio = new Episodio(
            1,
            "Estudo do Sermão da Montanha",
            45.00
        );

        Podcast podcast = new Podcast("Talmidim", "Douglas Gonçalves");
        podcast.AdicionarEpisodio(episodio);
        podcast.ExibirDetalhes();

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }
}