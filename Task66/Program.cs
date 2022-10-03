// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
{
    int M = 1;
    int N = 15;
    System.Console.WriteLine("M = " + M + ";N = " + N + "->" + Sum(M, N));
}
int Sum(int M, int N)
{
    
    int sum = M + N;
    if (M == N)
    {
        return M;
    }
    return sum + Sum(M + 1, N - 1);
}


