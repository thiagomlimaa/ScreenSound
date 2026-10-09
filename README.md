# 🎵 Screen Sound

Aplicação de console em C# para registrar bandas, avaliar com notas e ver a média de cada uma. Também tem uma demonstração com álbuns, músicas e podcast.

## Funcionalidades

- Registrar bandas (sem nome vazio e sem repetir)
- Listar todas as bandas registradas
- Avaliar uma banda com nota de 0 a 10
- Exibir a média de notas de uma banda
- Demonstração com banda, álbum, músicas e podcast com episódios

## Tecnologias

- C#
- .NET
- Programação Orientada a Objetos
- LINQ

## Como rodar

Você precisa do SDK do .NET instalado.

```bash
git clone https://github.com/thiagomlimaa/ScreenSound.git
cd ScreenSound
dotnet run
```

## Estrutura do projeto

```
├── Modelos/
│   ├── Album.cs
│   ├── Banda.cs
│   ├── Episodio.cs
│   ├── Genero.cs
│   ├── Musica.cs
│   └── Podcast.cs
├── Demonstracao.cs
└── Program.cs
```

## O que eu pratiquei

- Classes, propriedades e encapsulamento
- Coleções (`List`) e LINQ (`Any`, `FirstOrDefault`, `Average`)
- Validação de entrada com `int.TryParse`
- Menu com laço `do-while`
- Organização do código com pastas e namespace

## Autor

Tiago Moreira Lima
[LinkedIn](www.linkedin.com/in/devthiagolm)