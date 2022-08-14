
/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

Console.WriteLine("Ввести 2 числа, чтобы узнать какое большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Число " + number1 + " больше");
    Console.Write("Число " + number2 + " меньше");
}
else if (number1 == number2)
{
    Console.WriteLine("Число " + number1 + " равно числу " + number2);
}
else
{
    Console.WriteLine("Число " + number2 + " больше");
    Console.Write("Число " + number1 + " меньше");

} 


/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Ввести три числа, и узнать, какое из них имеет максимальное значение.");

Console.Write("Ввести первое число и нажать ENTER: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите ENTER: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число и нажмите ENTER: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxnumber= 0;
if (number1 > maxnumber) maxnumber = number1;
if (number2 > maxnumber) maxnumber = number2;
if (number3 > maxnumber) maxnumber = number3;
Console.Write("Максимальное значение имеет число " + maxnumber);



/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remain = number % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + number + " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " + number + " четное?");
    Console.WriteLine("НЕТ!");
}