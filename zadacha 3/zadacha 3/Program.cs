//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


Console.Clear();
void PrintArr(double[] array)
{
    Console.Write($"[{String.Join(", ", array)}]\n");
}
double[] GenerateArr(int  n, int min, int max)
{
    double[] arrNum = new double[n];
    Random rnd = new Random();
    for (int i =0; i < arrNum.Length; arrNum[i++]=rnd.Next(min, max)) { }
        return arrNum;
}
double Result(double[] array)
{
    double result = 0;
    double z = Int32.MinValue;
    double x = Int32.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > z)
            z = array[i];
        if (array[i] < x)
            x = array[i];
    }
    result = z - x;
    return result;
}
double[] array = GenerateArr(10, -10, 10);
PrintArr(array);
double res = Result(array);
Console.WriteLine($"Разница максимального и минимального элементов равна {res},");