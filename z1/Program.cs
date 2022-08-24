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

/* Console.WriteLine("Введите трехзначное число");
int n = int.Parse (Console.ReadLine());
Console.WriteLine(n%10);
 */


// Второй семинар массивы


/* int num = new Random().Next(10, 100); //включительно 99] поэтому до 100 указываем
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
    max= a2;
}
Console.WriteLine("Максимальная цифра в числе" + num + "->" + max); */

/* int num = new Random().Next(10, 1000); //убираем вторую цифру из трехзначного числа
int a = num / 100;
int b = num % 10;
int d = a*10+ b;
Console.WriteLine(num);
Console.WriteLine(d); */

/* Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
int d=0;
 while (d==0)
 {
    Console.WriteLine("Введите второе число не равное 0");
    d=int.Parse(Console.ReadLine());
 }
int c=a%d;
if (c==0)
{
   Console.WriteLine("кратно"); 
}
else
{
    Console.WriteLine(a + ","+ d + " не кратно" + "-> остаток "+ c);
} */

/*  Console.WriteLine("Введите число"); // является ли введеное чмсло кратным 7 и 23 одновременно
int a = int.Parse(Console.ReadLine());
if (a%161 ==0)
{
   Console.WriteLine("Число кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
} */

/* 
Console.WriteLine("Введите число"); // является ли введеное чмсло кратным 7 и 23 одновременно
int a = int.Parse(Console.ReadLine());
if (a%7 ==0 && a%23==0)
{
   Console.WriteLine("Число кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23 одновременно");
} */


/* Console.WriteLine("Введите первое целое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = int.Parse(Console.ReadLine());
if (b == Math.Pow(a,2)  )
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("Не кратно "+ a%b + " остаток");
} */









