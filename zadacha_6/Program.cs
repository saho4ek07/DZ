Console.WriteLine("Введите первое число ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number;


if (num % 2 == 1)
 {
    Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
 }
else
{
    Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
}