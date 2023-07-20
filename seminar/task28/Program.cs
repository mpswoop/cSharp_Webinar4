// input number N
// output multiplication of all numbers between 1 and N

Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int result = 1;

if (num == 0)

{
    Console.WriteLine("Result: 0");
}

else if (num < 0)

{
    for (int i = 1; -i >= num; i++)
    {
    result = result * i;
    }
}

else for (int i = 1; i <= num; i++)
{
    result = result * i;
}

Console.WriteLine($"Result: {result * -1}");