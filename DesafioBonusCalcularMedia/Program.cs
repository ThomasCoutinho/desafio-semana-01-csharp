Console.WriteLine("============================================");
Console.WriteLine("                DESAFIO BONUS               ");
Console.WriteLine("             CALCULANDO A MÉDIA             ");
Console.WriteLine("                META: MÉDIA 7               ");
Console.WriteLine("============================================");

Console.Write("\nDigite a nota do 1º trimestre: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota do 2º trimestre: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota do 3º trimestre: ");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("\n============================================");

double mediaFinal = CalcularMedia(nota1, nota2, nota3);

string resultadoFinal = mediaFinal >= 7 ? "APROVADO(A)!" : "REPROVADO(A)!";

Console.WriteLine($"A média final foi {mediaFinal:0.##}.");
Console.WriteLine(resultadoFinal);
Console.WriteLine("============================================");

double CalcularMedia(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    return media;
}