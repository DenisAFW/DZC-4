int Num(int a)
{
    int b = 0;
    while(a > 0)
    {
        b = a % 10 + b;
        a = a / 10;
    }
    return b;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма числе равна " + Num(a));