/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] GetRandomArray (int size, int minValue, int maxValue) {
    int [] result = new int [size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;

}

    int sumOdd (int [] arr) {
        int sum = 0;
        for (int i=0; i < arr.Length; i++) {
            if (arr[i] % 2 != 0){
            sum += arr[i];
            }
            } return sum;
    }

    int [] array = GetRandomArray(10, 0, 9);
    Console.WriteLine("Generated array: ");
    Console.WriteLine(String.Join(", ", array));
    int sum = sumOdd(array);
    Console.WriteLine($"Total sum of odd numbers is : {sum} ");