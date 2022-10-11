//Comentário de uma linha
//Alongamento
//Variável - Atribuição - Entrada e Saída
//Funções para String

/*
 * Comentários de múltiplas linhas
 */
Console.Write("Digite um nome: ");
string nome = Console.ReadLine();
Console.Write("Digite sua média: ");
double media = double.Parse(Console.ReadLine());
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
string mensagem = idade < 18 ? "mEnoR" : "mAiOr"; //erro lógico
Console.WriteLine($"{nome} sua média foi {media}");
Console.WriteLine($"{nome} você é {mensagem.ToUpper()}");

Console.WriteLine();
Console.Write("Press enter ...");
Console.ReadLine();