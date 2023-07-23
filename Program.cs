/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}
void ShowArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountChet(int[] array)
{
   int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i]%2 == 0) count += 1;
    return count;
}
Console.Write("Input a size of array" + " ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);
int n =  CountChet(myArray);
Console.WriteLine($"The number of even elements in the array {n}"); 
*/
/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
        array[i] = new Random().Next(-10, 20);
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumElements(int[] array)
{
    int sum = 0;
    for (int i=1; i<array.Length; i=i+2)
        sum = sum + array[i];
    return sum;
}
Console.WriteLine ("Input a size of array" + " ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);
int result = SumElements(myArray);
Console.WriteLine($"Sum of elements in even positions {result} "); 
*/
/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
double[] Array()
{
    Console.Write("Input a length: ");
    int length = Convert.ToInt32(Console.ReadLine());
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Input an element: "); 
        double number = Convert.ToDouble(Console.ReadLine());
        result[i] = number; 
    }

    return result;
}
void ShowArr(double[] array)
{
    Console.Write("Array: [  ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.Write(" ]");
}
double DifMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i]) max = array[i];
        else if (min >= array[i]) min = array[i];
    }
    double result = (max - min);
    result = Math.Round(result, 2); 
    return result;
}

double[] array = Array();
ShowArr(array);
double difMaxMin = DifMaxMin(array);
Console.WriteLine();
Console.WriteLine($"The difference between max and min {difMaxMin}");