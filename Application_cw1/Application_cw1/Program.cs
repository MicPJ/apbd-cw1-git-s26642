static int add(int x, int y)
{
    return x + y;
}

static int multiply(int x, int y)
{
    return x * y;
}

static double divide(int x, int y)
{
    return (double)x / y;
}

Console.WriteLine("Simple Calculator - main branch change before merge");

Console.WriteLine("5 + 6 = " + add(5,6));
Console.WriteLine("7 * 6 = " + multiply(7,6));
Console.WriteLine("8 / 6 = " + divide(8,6));

static double average(int[] tab){
    return tab.Average();
}