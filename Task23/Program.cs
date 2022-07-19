    Console.Write("Введите координату точки A на оси X  ");
double AX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A на оси Y  ");
double AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки А на оси Z  ");
double AZ = Convert.ToInt32(Console.ReadLine());


    Console.Write("Введите координату точки B на оси X  ");
double BX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B на оси Y  ");
double BY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B на оси Z  ");
double BZ = Convert.ToInt32(Console.ReadLine());


double Distance = Math.Sqrt(Math.Pow((AX-BX),2) + Math.Pow((AY-BY),2) + Math.Pow((AZ-BZ),2));
Console.WriteLine($"Расстояние между точками составляет: {Math.Round(Distance, 2)}");