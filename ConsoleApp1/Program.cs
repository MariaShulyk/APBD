Console.WriteLine("Hello, World!");
Console.WriteLine("Peace!");
Console.WriteLine("Love!");

int[] arr = new[] { 1, 2, 3};
Console.WriteLine(GetAvg(arr));

static double GetAvg(int[] arr)
{
    int result = 0;
    foreach (var num in arr)
    {
        result += num;
    }

    return (double)result / arr.Length;
}
