﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.WriteLine("Дана функция Аккермана А(n,m)");
Console.Write("Введите число n: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32 (Console.ReadLine());
static int A(int n, int m)
    {
        if (n == 0) return m+1;
        if (n != 0 && m == 0) return A(n-1,1);
        if (n > 0 && m > 0) return A(n-1, A(n,m-1));
        return A(n,m);
    }
Console.WriteLine("Функция Аккермана равна: " + A(n,m));