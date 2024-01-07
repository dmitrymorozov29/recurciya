// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N/

Console.WriteLine("Vvedite chislo M: ");
int M = Convert.ToInt32(ConsoleRead());
Console.WriteLine("Vvedite chislo N: ");
int N = Convert.ToInt32(ConsoleRead());
if (M > N)
{
    int TempN = N;
    N=M;
    M = TempN;
}
int Num = M+1;
int sum = 0;
int GetSumNums (int mewNum)
{
    if (newNum>=N)
    {
        return 0;
    }
    return sum + newNum + GetSumNums(newNum + 1);
}

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Vvedite znacheniye M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite znacheniye N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Znacheniye funkcii Akkermana ravno: {akkerman(m, n)} ");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int [] Array = new int [5]{1, 2, 3, 4, 5};
Console.WriteLine("Ishodniy massiv is pyati elementov: " + Array);
int ArrayMembersMirrow ()
{
    int numMember = Array[Array.Length];
    if (numMember == 0)
    {
        return 0;
    }
    numMember++;
    return numMember + ArrayMembersMirrow();
}
// Console.WriteLine($"Zerkalniy massiv{ArrayMembersMirrow()}: ");