Console.WriteLine("Введите первое число ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.WriteLine($"{numberFirst} больше чем {numberSecond} ");
}
else
{
    Console.WriteLine($"{numberSecond} больше чем {numberFirst} ");
}