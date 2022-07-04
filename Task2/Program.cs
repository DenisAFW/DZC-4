int[] Elements()
{
    int c = 8;
    int[] array = new int[c];
    for(int i = 0; i < c; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

void Print(int [] mass)
{
    String mis = string.Join(", ", mass);
    Console.WriteLine("[" + mis + "]");
}
Print(Elements());