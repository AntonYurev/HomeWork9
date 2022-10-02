// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
Console.Write("Введите число m: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32 (Console.ReadLine());
void Print()
            {
            for (int i = m; i <= n; i++)
                {
                    Console.Write(i + "\t" );
                }
            }
if (m>n) 
    {
       int a=m; m=n; n=a; 
    }
Print();