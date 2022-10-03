// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29
int m = 2;
int n = 3;
int AkkermanNum(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanNum(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanNum(m - 1, AkkermanNum(m, n - 1));
return AkkermanNum(m, n);
}
System.Console.WriteLine($"Результатом A{(m,n)} будет -> " + (AkkermanNum(m, n)));
