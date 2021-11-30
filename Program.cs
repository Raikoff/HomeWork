// ## Почувствуй себя интерном*
// 0. Вывести квадрат числа

int firstTaskValue = 6;
int firstTaskResult = firstTaskValue * firstTaskValue;
Console.WriteLine(firstTaskResult);


// 1. По двум заданным числам проверять является ли первое квадратом второго

int secondTaskFirstValue = 25;
int secondTaskSecondValue = 5;
int secondTaskResult = secondTaskSecondValue * secondTaskSecondValue;
if (secondTaskResult == secondTaskFirstValue)
{
Console.WriteLine("Первое число являеться квадратом второго");
}
else
{
    Console.WriteLine("Первое число не являетсья квадратом второго");
}


// 2. Даны два числа. Показать большее и меньшее число

int firstTaskFirstValue = 3;
int firstTaskSecondValue = 8;
if (firstTaskFirstValue > firstTaskSecondValue)
{
Console.WriteLine ("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}


// 3. По заданному номеру дня недели вывести его название

int weekDay = 3;
if (weekDay == 0)
{
Console.WriteLine("Понедельник");
}
else if (weekDay == 1)
{
Console.WriteLine("Вторник");
}
else if (weekDay == 2)
{
Console.WriteLine("Среда");
}
else if (weekDay == 3)
{
Console.WriteLine("Четверг");
}
else if (weekDay == 4)
{
Console.WriteLine("Пятница");
}
else if (weekDay == 5)
{
Console.WriteLine("Суббота");
}
else if (weekDay == 6)
{
Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Мы не знаем такого значения");
}

// 4. Найти максимальное из трех чисел

int a = 40;
int b = 100;
int c = 324;

int max = a;

if(a < b){
    max = b;
}
else
{
    max = a;
}
if (max < c)
{
    max = c;
}
Console.WriteLine(max);


/* 5. Написать программу вычисления значения функции y = f(a)
y = x - 1, x >= 0;
y = |x|, x < 0;
*/

int x = 4;
if (x >= 0)
{
Console.WriteLine(x - 1);
}
else if (x < 0)
{
    Console.WriteLine(Math.Abs(x));
}


//6. Выяснить является ли число чётным

int value = 6;

if(value % 2 == 0)
{
Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}

//7. Показать числа от -N до N

int num1 = -5;
while (num1 <= 5)
{
    num1++;
}
Console.WriteLine(num1);



//8. Показать четные числа от 1 до N


// 9. Показать последнюю цифру трёхзначного числа



//10. Показать вторую цифру трёхзначного числа

int number = 121;

int g = number / 10;
Console.WriteLine(g);
int h = g % 10;
Console.WriteLine(h);


//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number11 = 46;

int p = number11 / 10;
Console.WriteLine(p);

//12. Удалить вторую цифру трёхзначного числа

int number;

Console.WriteLine("Введите 3х значное число");

number = int.Parse(Console.ReadLine());

if()

//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//14. Найти третью цифру числа или сообщить, что её нет

//## Почувствуй себя джуном*


//15. Дано число. Проверить кратно ли оно 7 и 23


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;
int g = (num1 % num) & (num2 % num);
if (g >= 1)
{
    Console.WriteLine("Не кратно");
}
else
{
    Console.WriteLine("Кратно");
}

//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 


Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());

if (num == 6)
{
    Console.WriteLine("Суббота, выходной!!!");
}
else if(num == 7)
{
    Console.WriteLine("Воскресенье, выходной!!!");
}
else if(num != 6)
{
    Console.WriteLine("Пора работать!!!");
}

//17. По двум заданным числам проверять является ли одно квадратом другого


Console.Write("Введите первое число: ");

int num = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int num1 = int.Parse(Console.ReadLine());
int resul = num1;

if(resul == num * num)
{
Console.WriteLine(num1 + " является квадратом " + num );
}
else if(resul != num * num)
{
    Console.WriteLine(num1 + " не является квадратом " + num);
}



//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Write("Введите значение X true или false: ");
bool x = bool.Parse(Console.ReadLine());
Console.Write("Введите значение Y true или false: ");
bool y = bool.Parse(Console.ReadLine());
bool a = !(x || y) == !x ^ !y;
Console.WriteLine(a);

//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());
if((x == 0) && (y == 0 ))
{
    Console.WriteLine("X и Y  не могут быть равны 0, введите другие значения");
}

if((x > 0) && (y > 0))
{
    Console.WriteLine("Точка находиться в I четверти");
}
else if((x > 0) && (y < 0))
{
    Console.WriteLine("Точка находиться в II четверти");
}
else if((x < 0) && (y < 0))
{
    Console.WriteLine("Точка находиться в III четверти");
}

else if((x > 0) && (y < 0))
{
    Console.WriteLine("Точка находиться в IV четверти");
}

//20. Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int result = int.Parse(Console.ReadLine());

if(result == 1)
{
    Console.WriteLine("x>0;y>0");
}
else if(result == 2)
{
    Console.WriteLine("x<0;y>0");
}
else if(result == 3)
{
    Console.WriteLine("x<0;y<0");
}

else if(result == 4)
{
    Console.WriteLine("x>0;y<0");
}
if (result > 4)
{
Console.WriteLine("Такой четверти нет");
}
if (result < 1)
{
    Console.WriteLine("Такой четверти нет");
}

//21. Программа проверяет пятизначное число на палиндромом.


Console.Write("Введите пятизначное число: ");

int num = int.Parse(Console.ReadLine());

if (num <= 9999 || num >= 999999)
{
Console.WriteLine("Не умеешь считать до пяти?");
}
else if ((" + num[0]" == "" + num[5]) && (""+ num[1] == num[3]))
{
    Console.WriteLine("Число проверяеться на полидромом");
}
    


//22. Найти расстояние между точками в пространстве 2D/3D

char version;
 Double x1, x2, y1, y2, z1, z2, rasst; // вводим переменные

 Console.WriteLine("1. Найти расстояние между точками в пространстве 2D");
 Console.WriteLine("2. найти расстояние между точками в пространстве 3D");
 Console.WriteLine("Выбирите пункт 1 или 2: ");


 version = Convert.ToChar(Console.ReadLine());
// делим решение на две части 2D и 3D
 switch (version)    
   {
      
      case '1':

     Console.Write("Введите X1: ");
     x1 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите Y1: ");
     y1 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите X2: ");
     x2 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите Y2: ");
     y2 = Convert.ToDouble(Console.ReadLine());

     rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //  формула раасчета
    
     Console.WriteLine("Растояние: " + rasst);
     Console.ReadKey(); // возвращение в терминал
     break;

     case '2': 

     Console.Write("Введите X1: ");
     x1 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите Y1: ");
     y1 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите Z1: ");
     z1 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите X2: ");
     x2 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите Y2: ");
     y2 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Введите Z2: ");
     z2 = Convert.ToDouble(Console.ReadLine());

     rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

     Console.WriteLine("Результат" + rasst);
     Console.ReadKey();
     break;
 
     default:
     Console.WriteLine("Неверное значение");
     Console.ReadKey();
     break;

    }

// ## Почувствуй себя мидлом*
//23. Показать таблицу квадратов чисел от 1 до N 
//24. Найти кубы чисел от 1 до N
//25. Найти сумму чисел от 1 до А
//26. Возведите число А в натуральную степень B используя цикл
//27. Определить количество цифр в числе
//28. Подсчитать сумму цифр в числе
//29. Написать программу вычисления произведения чисел от 1 до N
//30. Показать кубы чисел, заканчивающихся на четную цифру

// ## Почувствуй себя сеньором*
//31. Задать массив из 8 элементов и вывести их на экран 
//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
//33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
//34. Написать программу замену элементов массива на противоположные
//35. Определить, присутствует ли в заданном массиве, некоторое число 
//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
//39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// ## Почувствуй себя лидом*
//41. Выяснить являются ли три числа сторонами треугольника 
//42. Определить сколько чисел больше 0 введено с клавиатуры
//43. Написать программу преобразования десятичного числа в двоичное
//44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
//45. Показать числа Фибоначчи
//46. Написать программу масштабирования фигуры