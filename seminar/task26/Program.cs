// input number, output no of digits
Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int digits = 0;

for (int i = 0; num > 0; i++)

{
    num = num / 10;
    digits++ ;
}
        
Console.WriteLine($"the number has {digits} digits");
