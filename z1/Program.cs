/* Console.WriteLine("Введите число");
string numberStr;
numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
Console.WriteLine(number*number);

  */

/* Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if (b*b == a)
{
    Console.WriteLine("Перове число является квадратом второго числа");
}
else 
{
    Console.WriteLine("Перове число  не является квадратом второго числа");
}
 */



/* Console.WriteLine("Введите 3 или 5");
string numberStr;
numberStr = Console.ReadLine();
if (numberStr == "3")
{
    Console.WriteLine("среда");
}
else if (numberStr == "5")
{
    Console.WriteLine("пятница");
}
else
{
    Console.WriteLine("Введите 3 или 5");
}
 */


/* Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int i = 0;
int a = 2*(number);
Console.WriteLine("Ответ: ");
while (i<=a)
{
    Console.WriteLine(-number);
    i++;
    number--;
} */


/* Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int a= n*(-1);
while (a<=n)
{
  Console.WriteLine(a);
  a++;  
} */

Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n%10);

