// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// n = 3, m = 2 -> A(m,n) = 29
// n = 3, m = 11 -> A(m,n) = 16381
int AkkermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AkkermanFunction(n - 1, 1);
    }
    else
    {
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    }
}

Console.WriteLine("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());

int result = AkkermanFunction(m, n);
Console.WriteLine($"Результат выполнения функции Аккермана для a({m}, {n}) = {result}");

