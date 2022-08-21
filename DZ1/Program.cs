// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: "); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write ("max = " );
    Console.WriteLine( a) ;  
    Console.Write ("min = " );
    Console.WriteLine(b); 
}
else if (a < b )
{
    Console.Write ("max = " );
    Console.WriteLine( b) ;  
    Console.Write ("min = " );
    Console.WriteLine(a);
}
if (a==b)
{
    Console.WriteLine("Числа совпадают!");
} 



// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/* Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write ("max = " );
Console.WriteLine(max);   
 */


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/* Console.Clear(); 
Console.WriteLine("Добрый день! Введите пожалуйста число: ");
int n = int.Parse(Console.ReadLine());
if (n%2 == 0)
{
    Console.WriteLine("Введенное вами число является ЧЕТНЫМ!");
} 
else 
{
    Console.WriteLine("Введенное вами число  НЕ является ЧЕТНЫМ!"); 
}
 */



//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/* 
Console.Clear();
Console.WriteLine("Добрый день! Введите пожалуйста число, чтобы  на выходе увидеть все чётные числа от 1 до указанного числа (включительно): ");
int N = int.Parse(Console.ReadLine());
int a = 0;

Console.WriteLine("Ответ: ");

while (a < N-1)
{
    Console.Write(a+2);
    Console.Write(" ");
    a=a+2;
}
if (N <=1 )
{
  Console.WriteLine("Введите пожалуйста число больше 1, чтобы выполнить условие задачи."); 
} */


