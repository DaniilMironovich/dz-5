// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0


Console.Clear();    
void PrintArr(int[] array)
{
    Console.Write($"[{String.Join(", ", array)}]\n");
}
int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum= new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max)) { }
    return arrNum;
}
int ElementSum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}
int[] array = GenerateArr(10, -100, 101);
PrintArr(array);
int res = ElementSum(array);
Console.Write($"Сумма элементов массива стоящих на нечетных позициях равна {res}");