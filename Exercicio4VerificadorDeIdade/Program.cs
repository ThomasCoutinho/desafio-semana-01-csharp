Console.WriteLine("============================================");
Console.WriteLine("            VERIFICADOR DE IDADE            ");
Console.WriteLine("============================================");

Console.Write("Digite seu ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = DateTime.Now.Year - anoNascimento;

Console.WriteLine("\n============================================");
Console.WriteLine($"Você tem {idade} anos.");

string verificaIdade = idade >= 18 ? "maior de idade!" : "menor de idade!";

Console.WriteLine($"Portanto, é {verificaIdade}");
Console.WriteLine("============================================");
