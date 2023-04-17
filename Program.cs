using Calculadora;

Calculo calculo = new Calculo();

Console.WriteLine("Digite o primeiro número:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tipo da operação:");
string operacao = Console.ReadLine().ToLower();


if (operacao == "soma" ||  operacao == "somar")
{
    Console.WriteLine();
    Console.WriteLine("O resultado do cáculo é: " + calculo.Soma.Calcular(num1, num2));
}
else if  (operacao == "divisao" || operacao == "divisão" || operacao == "dividir")
{
    Console.WriteLine();
    Console.WriteLine("O resultado do cáculo é: " + calculo.Divisao.Calcular(num1, num2));
}
else if (operacao == "multiplicacao" || operacao == "multiplicação" || operacao == "multiplicar")
{
    Console.WriteLine();
    Console.WriteLine("O resultado do cáculo é: " + calculo.Multiplicacao.Calcular(num1, num2));
}
else if (operacao == "subtracao" || operacao == "subtração" || operacao == "subtrair")
{
    Console.WriteLine();
    Console.WriteLine("O resultado do cáculo é: " + calculo.Subtracao.Calcular(num1, num2));
}
else
{
    Console.WriteLine();
    Console.WriteLine("Digite uma operação válida!");
}