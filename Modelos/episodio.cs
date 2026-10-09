using System;
using System.Collections.Generic;

namespace ScreenSound.Modelos;

public class Episodio
{
    private List<string> listaDeConvidados = new List<string>();

    public Episodio(int ordem, string titulo, double duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }
 
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", listaDeConvidados)}";
    public int Ordem { get; }
    public string Titulo { get; }
    public double Duracao { get; }

    public void AdicionarConvidados()
    {
        Console.WriteLine("Digite o nome do convidado:");
        string nomeConvidado = Console.ReadLine()!;

        listaDeConvidados.Add(nomeConvidado);
    }
}