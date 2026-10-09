using System;

namespace ScreenSound.Modelos;

public class Musica
{
    // Construtor
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome { get; set; } = string.Empty;
    public Banda Artista { get;}
    public  int Duracao {get; set;}
    public bool Disponivel { get; set;}
    public Genero? Genero {get; set;}

    // Propriedade Somente leitura: (get) com Lambda
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista.Nome}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero?.Nome}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }

    }
}

























// Atividade POO

// 1-

// class ContaBancaria
// {
//     public int NumIndicador {get; set;}
//     public string Titular {get; set;}
//     public double Saldo {get; set;}
//     public int Senha {get; set;}
//     public string BreveStatus => $"{Titular} você tem R${Saldo},00 reias em sua conta";


//     public void ExibirInforcao()
// {
//     Console.WriteLine($"Número do Indicador: {NumIndicador}");
//     Console.WriteLine($"Nome do Titular: {Titular}");
//     Console.WriteLine($"Saldo da Conta: {Saldo}");
//     Console.WriteLine($"Senha da conta: {Senha}");
// }
// }


// 2-

// class carro
// {
//     public string Modelo { get; set; }
//     public string Marca { get; set; }

//     private int ano;

//     public int Ano
//     {
//         get
//         {
//             return ano;
//         }

//         set
//         {
//             if (value >= 1960 && value <= 2023)
//             {
//                 ano = value;
//             }
//         }
//     }

//     public void exibirInfoCarro()
//     {
//         Console.WriteLine($"A marca desse carro é: {Marca}");
//         Console.WriteLine($"O modelo desse carro é: {Modelo}");
//         Console.WriteLine($"O ano desse carro é: {Ano}");
//     }
// }