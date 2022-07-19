Console.Write("Введите число   ");
int i;
int Number = Convert.ToInt32(Console.ReadLine());
double Cube;
for (i=1;  i<Number; i++)
{
    Cube = Math.Pow(i,3); 
    Console.Write($"{Cube}, ");
}
Cube = Math.Pow(i, 3);
Console.WriteLine(Cube);
