// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

/*
Console.Clear();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

string rec(int m, int n)
{
    if (m == n)
        return $"{n} ";
    return rec(m, n - 1) + $"{n} ";
}

Console.Write(rec(m, n));
*/

//---------------------------------------------------------------------------------------

// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int rec(int m, int n)
{
    if(m == 0)
        return n + 1;
    if(m > 0 && n == 0)
        return rec(m - 1, 1);
    if(m > 0 && n > 0)
        return rec(m - 1, rec(m, n - 1));
    return rec(m, n);
}

Console.WriteLine(rec(m, n));
*/

//--------------------------------------------------------------------------------------------------

// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

/*
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

string result(string str)
{
    if (str.Length == 0)
        return "";
    return $"{str[str.Length - 1]}" + result(str.Remove(str.Length - 1));
}


Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
string str = string.Join(" ", array);
Console.WriteLine(str);
Console.WriteLine(result(str));
*/


