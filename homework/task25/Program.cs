// loop accepting two numbers A & B and multiplying A by itself b times
// 3, 5 = 3 x 3 x 3 x 3 x 3
Console.WriteLine("please input number A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input number B");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine($"result: {result}"); 