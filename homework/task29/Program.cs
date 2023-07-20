// Array of 8 elements using random numbers
Console.WriteLine("this is an array of 8 random numbers");

int[] numbers = new int[8];

for (int i = 0; i < 8; i++)
{
    numbers[i] = new Random().Next(0, 1000000000);
    Console.WriteLine($"Element #{i+1}: {numbers[i]}");
}    