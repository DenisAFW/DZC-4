int ar_len = 8;
int Elements()
{
    int[] array = new int[ar_len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

