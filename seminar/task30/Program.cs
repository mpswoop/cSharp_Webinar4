// create array of 8 random elements between 0 and 1
Console.WriteLine("array of 8");

int[] numbers = new int[8];
for (int i = 0; i < 8; i++)
{
    numbers[i] = new Random().Next(0, 10);
    Console.Write(numbers[i]);
}
Console.WriteLine();
