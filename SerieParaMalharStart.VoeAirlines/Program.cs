using SerieParaMalharStart.VoeAirlines.Entities;

Aeronave aeronave = new Aeronave();
//Aeronave: classe
//Aero: objeto da classe
// = : atribuição
// new: Operador de instanciação - é um objeto, ele define o objeto (concretização de uma classe)
// Aeronave(): chamada ao construtor 

//Interface de usuario
Console.WriteLine("Digite o fabricante: ");
var entradaFabricante = Console.ReadLine();
Console.WriteLine("Digite a matrícula: ");
var entradaMatricula = Console.ReadLine();
Console.WriteLine("Digite o modelo: ");
var entradaModelo = Console.ReadLine();
Console.WriteLine("Digite o código: ");
var entradaCodigo = Console.ReadLine();
Console.WriteLine("Digite a quantidade de passageiros: ");
var entradaQtdePassageiros = int.Parse(Console.ReadLine());
Console.WriteLine("Nome do propietário");
var entradaCelebridade = Console.ReadLine();

//Atribuições
aeronave.Fabricante = entradaFabricante;
aeronave.Matricula = entradaMatricula;
aeronave.Modelo = entradaModelo;
aeronave.Codigo = entradaCodigo;
aeronave.Capacidade = entradaQtdePassageiros;
aeronave.Celebridade = entradaCelebridade;

Console.WriteLine();

//Noticia
Console.WriteLine($"Jatinho executuvo do {aeronave.Celebridade} é um {aeronave.Modelo} - {aeronave.Codigo}. " +
                    $"Fabricado pela {aeronave.Fabricante} de matrícula '{aeronave.Matricula}'. ");

Console.ReadLine();
