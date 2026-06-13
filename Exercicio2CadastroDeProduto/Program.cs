Console.WriteLine("============================================");
Console.WriteLine("              CADASTRO PRODUTO              ");
Console.WriteLine("============================================");

Console.Write("Digite o nome do produto: ");
var nomeProduto = Console.ReadLine();

// parse converte a string em outro tipo
Console.Write("Digite o preço unitário do produto: ");
decimal precoProduto = decimal.Parse(Console.ReadLine()); 

Console.Write("Digite a quantidade que deseja cadastrar: ");
int quantProduto = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("============================================");
Console.WriteLine("       Produto cadastrado com sucesso!      ");
Console.WriteLine("============================================");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço unitário: R$ {precoProduto}");
Console.WriteLine($"Quantidade em estoque: {quantProduto}");
Console.WriteLine("============================================");