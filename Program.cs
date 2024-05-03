int numero;

Console.Write("digite o primeiro numero:");
numero = Convert.ToInt32(Console.ReadLine());

int numero2;

Console.Write("digite o segundo numero:");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero > numero2)
{
    Console.WriteLine ($"{numero} é maior");

}
else 
{
    Console.WriteLine($"{numero2} é maior");
}

