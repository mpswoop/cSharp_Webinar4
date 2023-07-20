// input number and output sum of digits
Console.WriteLine("please input a number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{ 
    number = number * -1;
}

int result = 0;
int exponent = 1;
int temporary = 1;

for (int i = 0; temporary > 0; i++)
{
    result = result + number / exponent % 10;
    exponent = exponent * 10;
    temporary = number / exponent % 10;
}

Console.WriteLine();
Console.Write($"Result: {result}");
Console.WriteLine();



// int digit1 = number % 10;
// int digit2 = number / 10 % 10;
// int digit3 = number / 100 % 10;
// int digit4 = number / 1000 % 10;
// int digit5 = number / 10000 % 10;
// int digit6 = number / 100000 % 10;
// int digit7 = number / 1000000 % 10;
// int digit8 = number / 10000000 % 10;
// int digit9 = number / 100000000 % 10;
// int digit10 = number / 1000000000 % 10;


// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
// Console.WriteLine(digit3);
// Console.WriteLine(digit4);
// Console.WriteLine(digit5);
// Console.WriteLine(digit6);
// Console.WriteLine(digit7);
// Console.WriteLine(digit8);
// Console.WriteLine(digit9);
// Console.WriteLine(digit10);

// Console.WriteLine();
// Console.Write("Result: ");
// Console.WriteLine(digit1 + digit2 + digit3 + digit4 + digit5 + digit6 + digit7 + digit8 + digit9 + digit10);
