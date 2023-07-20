// Two segments with coordinates X1&X2 and X3&X4
// do they have a common field and if yes where is it
Console.WriteLine("please input first coordinate of first segment");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input second coordinate of first segment");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input first coordinate of second segment");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input second coordinate of second segment");
int x4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"First segment: {x1}, {x2}");
Console.WriteLine($"First segment: {x3}, {x4}");
Console.WriteLine("");


if (x1 > x2)
{
    int temp = x1;
    x1 = x2;
    x2 = temp;
}

if (x3 > x4)
{
    int temp = x3;
    x3 = x4;
    x4 = temp;
}

Console.WriteLine($"First segment: {x1}, {x2}");
Console.WriteLine($"First segment: {x3}, {x4}");
Console.WriteLine("");

if (x3 > x2 || x4 < x1)
{
    Console.WriteLine("There is a common field");
}

else

Console.WriteLine("There is no common field");