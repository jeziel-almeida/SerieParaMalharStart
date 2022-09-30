// Crie um programa que leia um número inteiro e retorne o número juntamente com o seu tipo

Console.Write("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Número: {num}. Tipo: {num.GetType()}.");

Console.ReadLine();