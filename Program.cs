// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("vvodite chislo X_");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("vvodite chislo Y_");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    System.Console.WriteLine("tochka naxoditsya pervoy kordinatnoy cetverti");
}
if(x < 0 && y > 0)
{
    System.Console.WriteLine("tochka naxoditsya vtoroy kordinatnoy cetverti");
}
if(x < 0 && y < 0)
{
    System.Console.WriteLine("tochka naxoditsya tretiey kordinatnoy cetverti");
}
if(x > 0 && y < 0)
{
    System.Console.WriteLine("tochka naxoditsya cetvertoy kordinatnoy cetverti");
}



// Задача №18.  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int n = Convert.ToInt32(Console.ReadLine());

if(n < 1 || n > 4) { System.Console.WriteLine("est tolko cetiri kordinatni cetverti");}
else if(n == 1) { System.Console.WriteLine("x > 0 && y > 0"); }
else if(n == 2) { System.Console.WriteLine("x < 0 && y > 0"); }
else if(n == 3) { System.Console.WriteLine("x < 0 && y < 0"); }
else if(n == 4) { System.Console.WriteLine("x > 0 && y < 0"); }


// Задача №20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

System.Console.WriteLine("vedite kordinati x");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("vedite kordinati y");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("vedite kordinati x1");
int a1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("vedite kordinati y1");
int b1 = Convert.ToInt32(Console.ReadLine());

double rez = Math.Sqrt(Math.Pow(a1-a,2)+ Math.Pow(b1-b,2));
System.Console.WriteLine($"itog:{rez:f2}");


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int n1 = Convert.ToInt32(Console.ReadLine());
int i=1;
for(i=1; i<=n1; i++) {System.Console.WriteLine($"квадратов чисел от 1 до {n1} gde {i}^2 {i * i}");}


// Задача 19 : Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int number = Convert.ToInt32(Console.ReadLine());
int rem;
int rezalt = 0;
int temp = number;

while (number != 0)
{
    rem = number % 10;
    rezalt = rezalt * 10 + rem;
    number = number / 10;
}

number = temp;
if (number == rezalt)
{
    System.Console.WriteLine("dis iz a polendrome");
}
else
{
    System.Console.WriteLine("dis !Not polendrome");
}




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int k1 = Convert.ToInt32(Console.ReadLine());

if (k1 > 0)
{
   int kub = 0;
   kub = n1*n1*n1;
   System.Console.WriteLine(kub);
}





