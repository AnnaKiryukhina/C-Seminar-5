// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[12];
Random rand = new Random();

 for (int i = 0; i < array.Length; i++)
{
     array[i] = rand.NextDouble(); 
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void MaxMin (double[] array, out double max, out double min, out double dif)
{
 max = array[0];
 min = array[0];
    
   
  for (int i = 0; i < array.Length; i++)
  {
        if (array[i] > max) //(array[i] % 2 < 1)
        {
            max = array[i]; 
        }

        if (array[i] < min)
               {
             min = array[i];
         }

  }
      dif = max-min;
 }


PrintArray(array);
MaxMin (array, out double min, out double max, out double dif);
System.Console.WriteLine($"минимальное: {max}, максимальное {min}");
System.Console.WriteLine($"разница {dif}");




 