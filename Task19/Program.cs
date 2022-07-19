int Numbers;
Console.WriteLine("Введите любое пятизначное число");
Numbers = Convert.ToInt32(Console.ReadLine());
int digit1 = Numbers/10000;
int digit2 = Numbers/1000%10;
int digit4 = Numbers %100/10;
int digit5 = Numbers%10;
{
    if (digit1 == digit5 && digit2 == digit4)
    Console.WriteLine("Это число является палиндромом");
    else
    Console.WriteLine("Это число не является палиндромом");
}

