// Expressão switch
string linguagem = "CSS";
string retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação",
    "CSS" => "Linguagem de estilos",
    "C#" => "Linguagem de programação",
    _ => "Linguagem desconhecida"
};

Console.WriteLine(retorno);