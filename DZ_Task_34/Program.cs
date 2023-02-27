// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // [100, 1000) 
    }
    
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void CountEvenNumbers(int[] array, out int countEven)
{
    countEven = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 > 0)
        {
            countEven = i++; // sumEven = sumEven + array[i]
        }
        
    }
}

const int SIZE = 6;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;

var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
CountEvenNumbers(myArray, out int countE);
System.Console.WriteLine($"Сумма четных чисел: {countE}");
