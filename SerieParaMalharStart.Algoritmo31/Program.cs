// Crie um programa que mostre a média aritmética de 3 números fornecidos pelo usuário

Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Digite o terceiro número: ");
double num3 = double.Parse(Console.ReadLine());

double media = (num1 + num2 + num3) / 3;

Console.WriteLine($"A média é {media}.");

Console.ReadLine();