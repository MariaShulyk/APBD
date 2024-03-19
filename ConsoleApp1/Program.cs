Console.WriteLine("Hello, World!");
Console.WriteLine("Peace!");
Console.WriteLine("Love!");

int[] arr = new[] { 1, 2, 3};
Console.WriteLine(GetAverage(arr));
Console.WriteLine(FindMax(arr));

static double GetAverage(int[] arr)
{
    int result = 0;
    foreach (var num in arr)
    {
        result += num;
    }

    return (double)result / arr.Length;
}

static int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}