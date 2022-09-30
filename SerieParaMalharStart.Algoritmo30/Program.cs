// Crie um programa que leia dois números e mostre o produto deles

Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

double produto = num1 * num2;

Console.WriteLine($"O produto de {num1} e {num2} é {produto}.");

Console.ReadLine();