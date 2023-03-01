Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int sum = 0, num;

while (number > 0)
{
    num = number % 10;
    sum = sum + num;
    number = number / 10;
}

Console.WriteLine($"The sum of the digits is: {sum}");