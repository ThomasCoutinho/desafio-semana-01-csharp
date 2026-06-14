Console.WriteLine("============================================");
Console.WriteLine("            CALCULADORA SIMPLES             ");
Console.WriteLine("============================================");

Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

//optei por usar double para caso seja utilizado números com casas decimais

double soma = num1 + num2;
double subtracao = num1 - num2;
double multiplicacao = num1 * num2;
double divisao = num1 / num2;

Console.WriteLine("============================================");

Console.WriteLine($"{num1} + {num2} = {soma:0.##} ");

Console.WriteLine($"{num1} - {num2} = {subtracao:0.##} ");

Console.WriteLine($"{num1} * {num2} = {multiplicacao:0.##} ");

Console.WriteLine($"{num1} / {num2} = {divisao:0.##} ");

Console.WriteLine("============================================");

// usei 0.## para o programa usar as casas decimais apenas quando necessário