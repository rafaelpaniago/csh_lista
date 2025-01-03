// Variavel chamada linguagem que pode conter diversos tipos de linguagem.
// Dependendo da linguagem, vamos retornar um pequeno texto.

// Variável 
string linguagem = "C#";

// Estrutura de escolha
switch(linguagem)
{
    case "HTML":
    Console.WriteLine("Linguagem de marcação");
    break;

    case "CSS":
    Console.WriteLine("Linguagem de estilos");
    break;

    case "C#":
    Console.WriteLine("Linguagem de programação");
    break;

    default:
    Console.WriteLine("Linguagem desconhecida");
    break;
}
