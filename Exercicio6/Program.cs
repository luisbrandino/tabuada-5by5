int number = 0;

while (number <= 0)
{
    Console.Write("Informe um número inteiro e positivo para mostrar sua tabuada: ");
    number = int.Parse(Console.ReadLine());
}

for (int i = 0; i <= 10; i++)
    Console.WriteLine($"{number} x {i} = {number * i}");
