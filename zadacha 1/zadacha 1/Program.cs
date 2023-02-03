// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
void PrintArr(int[] array)
{
    Console.Write($"[{String.Join(",", array)}]\n");
}
int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int [n];
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max)) { }
    return arrNum;
}
int PositiveNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
    }
    return result;
}
Console.WriteLine("Сейчас мы посчитаем количество четных чисел в случайном массиве");
int[] array = GenerateArr(50, 100, 1000);
PrintArr(array);
int res = PositiveNumber(array);
Console.Write($"Количество четных чисел равно {res}");
