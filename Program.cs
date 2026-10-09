using  ScreenSound.Modelos;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

List<Banda> bandas = new List<Banda>();

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    int opcaoEscolhidaNumerica;

    do
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite 5 para exibir demonstração");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;

        if (!int.TryParse(opcaoEscolhida, out opcaoEscolhidaNumerica))
        {
            Console.WriteLine("Digite apenas números!");
            Thread.Sleep(2000);
            continue;
        }

        switch (opcaoEscolhidaNumerica)
        {
            case 1: RegistrarBanda();
                break;
            case 2: MostrarBandasRegistradas();
                break;
            case 3: AvaliarUmaBanda();
                break;
            case 4: ExibirMedia();
                break;
            case 5: Demonstracao.Exibir();
                break;
            case -1: Console.WriteLine("Tchau tchau :)");
                break;
            default: Console.WriteLine("Opção inválida");
                Thread.Sleep(2000);
                break;
        }
    } while (opcaoEscolhidaNumerica != -1);
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

if (string.IsNullOrWhiteSpace(nomeDaBanda))
{
    Console.WriteLine("\nO nome da banda não pode ficar vazio!");
    Thread.Sleep(2000);
    return;
}

if (bandas.Any(b => b.Nome == nomeDaBanda))
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} já está registrada!");
        Thread.Sleep(2000);
        return;
    }

    Banda banda = new Banda();
    banda.Nome = nomeDaBanda;
    bandas.Add(banda);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2500);
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (Banda banda in bandas)
    {
        Console.WriteLine($"Banda: {banda.Nome}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();    
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    Banda? banda = bandas.FirstOrDefault(b => b.Nome == nomeDaBanda);

    if (banda != null)
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece (0 a 10): ");

        if (!int.TryParse(Console.ReadLine(), out int nota) || nota < 0 || nota > 10)
        {
            Console.WriteLine("\nNota inválida! Digite um número de 0 a 10.");
            Thread.Sleep(2000);
            return;
        }

        banda.AdicionarNota(nota);

        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    Banda? banda = bandas.FirstOrDefault(b => b.Nome == nomeDaBanda);

    if (banda != null)
    {
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }
}

ExibirOpcoesDoMenu();
