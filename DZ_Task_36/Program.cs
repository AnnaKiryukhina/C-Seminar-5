// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
    array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void SumElements(int[] array, out int sumElements)
{
    sumElements = 0;
   
    for (int i = 0; i < array.Length; i=i+2)
    {
        
            sumElements += array[i]; // sumPositive = sumPositive + array[i]
        
    }
}

const int SIZE = 6;
const int LEFT_RANGE = 10;
const int RIGHT_RANGE = 100;

var myArray = GenArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
SumElements(myArray, out int sumElements);
System.Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях: {sumElements}");