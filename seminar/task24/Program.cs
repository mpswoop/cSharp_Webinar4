// calculate sum of numbers from one to input
// 4--> 10
// 7-->28
// 8-->36

Console.WriteLine("please input number");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number <= 0)
{
    Console.WriteLine("wrong input");
}

else

for (int i = 1; i <= number; i++)
{
    // result = result + i;
    result += i;
}

Console.WriteLine($"Sum is: {result}");
