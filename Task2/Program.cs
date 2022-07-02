void Elements()
{
    int i = 1;
    int a = 0;
    int array = Convert.ToInt32(8);
    Console.Write("[");
    while (i < array)
    {
        a = new Random().Next(-1000, 1000);
        Console.Write(a + ", ");
        i++;
    }
    Console.Write(a + "]");
}
Elements();