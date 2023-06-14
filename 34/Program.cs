/*  Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел
 в массиве.
[345, 897, 568, 234] -> 2
*/

int [] GetRandomArray (int size, int minValue, int maxValue) {
    int [] result = new int [size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;

}

    int findEven (int [] arr) {
        int even = 0;
        for (int i=0; i < arr.Length; i++) {
            if (arr[i] % 2 == 0){
            even++;
            }
            } return even;
    }

    int [] array = GetRandomArray(10, 0, 9);
    Console.WriteLine("Generated array: ");
    Console.WriteLine(String.Join(", ", array));
    int even = findEven(array);
    Console.WriteLine($"Amount of even numbers in array is: {even} ");