void Elements()
{
    int c = 8;
    int[] array = new int[c];
    for(int i = 0; i < c; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
        Console.Write(array[i] + ", ");
    }
}
Elements();
// Не смог додумать два метода, не смог привести один метод(Elements), на метод вывода.