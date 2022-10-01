Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Descubra se é... ou não é!");
Console.ResetColor();

int n1;

Console.Write("Digite um número:");
n1 = Convert.ToInt32(Console.ReadLine());

if (n1 <0)
{
    Console.WriteLine($"\n{n1} é negativo");
}
else
{
    Console.WriteLine($"\n{n1} é positivo");
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nValeu por usar!");
Console.ResetColor();