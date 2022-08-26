//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/* Console.Clear();
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
while (a<100 || a>=1000)
{
    Console.WriteLine("Введите трехзначное число");
    a = int.Parse(Console.ReadLine());
}
 int b = a/10;
int result= b%10; 
Console.WriteLine("Вторая цифра числа -> " + result);
  */


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/* Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
a=Math.Abs(a); 
int i=1000;
int n=1;

if (a < 100 && a >-100)
{
 Console.WriteLine("В числе нет третьей цифры!");
}
else
{
while (a > i )
{
    i=i*10;
    n=n*10;
   
}
Console.WriteLine("Третья цифра числа -> " + (a/n)%10);
} */

/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

/* Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели, чтобы узнать является ли этот день выходным: ");
int a = int.Parse(Console.ReadLine());

while (a<1 || a>7)
{
    Console.WriteLine("Введите цифру от 1 до 7");
    a = int.Parse(Console.ReadLine());
}

if (a >0 && a<6)
{
    Console.WriteLine(a + " - > рабочий день");
}
else
{
    Console.WriteLine (a + " - > выходной");
}
 */

