/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double [] GetRandomArray (int size) {
    double [] result = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++) {
        result[i] = rand.NextDouble();
    }
    return result;

}

    double MaxMinDif (double [] arr) {
        double min = arr[0];
        double max = arr[arr.Length-1];
        for (int i=0; i < arr.Length; i++) {
            if (arr[i] < min){
            min = arr[i];
            } else if (arr[i] > max){
            max = arr[i];
            } 
    }
    double diff = max - min;
    return diff;
    }

    double [] array = GetRandomArray(10);
    Console.WriteLine("Generated array: ");
    Console.WriteLine(String.Join(", ", array));
    double diff = MaxMinDif(array);
    Console.WriteLine($"Difference of max and min is : {diff} ");