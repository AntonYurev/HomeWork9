// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число m: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32 (Console.ReadLine());
void Sum()
    {
        int sum=0;
        for (int i=m; i<=n;i++)
            {
                sum = sum + i;
            }
        Console.Write($"Сумма чисел от {m} до {n} равна {sum}");
    }
if (m>n) 
    {
       int a=m; m=n; n=a; 
    }
Sum();