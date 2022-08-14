/*
Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
 
Console.Write("Введите число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32 (Console.ReadLine());
if ( a > b )
    Console.WriteLine($"max = {a}, min = {b}");
else
    Console.WriteLine($"max = {b}, min = {a}");
 
*/

/*
 
//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
//из этих чисел.

Console.Write("Введите число n1: ");
int n1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число n2: ");
int n2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число n3: ");
int n3 = Convert.ToInt32 (Console.ReadLine());
 
int max = n1;
 
if (n1 > max) 
    max = n1;
if (n2 > max)
    max = n2;
if (n3 > max)
    max = n3;
 
Console.WriteLine($"Максимальное число {max}");

*/
 
/*
//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
 
Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
 
if (number % 2 == 0)
    Console.Write($"Число {number} четное");
else
    Console.Write($"Число {number} нечетное");
 
*/
/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int current = 1;

while (current <= number)
{
    if (current % 2 == 0)
        Console.Write(current + " ");
current++;
}
 
 */

 