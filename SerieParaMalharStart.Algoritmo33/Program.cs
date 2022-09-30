try
{
    Console.Write("Digite um número inteiro: ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine($"Número: {num}. " +
                      $"Antecessor: {num - 1}. " +
                      $"Sucessor: {num + 1}.");
} catch (FormatException)
{
    Console.WriteLine("O valor informado não é inteiro.");
}

Console.ReadLine();
