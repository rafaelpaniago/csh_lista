// Teremos duas informações. Valor de compra e forma de pagamento.
// Se o cliente efetuou compra de 100 a vista, tem desconto 10%.

// Variáveis
double valor = 500;
string pagamento = "À vista";

// Condicional
if(valor >= 100 && pagamento == "À vista")
{
    Console.WriteLine($"Desconto de 10%! Total: R${valor*0.9}");
}
else
{
    Console.WriteLine($"Total: R${valor}");
}