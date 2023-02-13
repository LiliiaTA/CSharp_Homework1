/* Задача 35: Задайте одномерный массив из 123 случайных чисел [0: 1000].
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/

Console.Clear();
int[] array = GetRandomArray(123, 0, 1000);
Console.WriteLine($"Массив из 123 элементов: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {CountEl(array, 10, 99)}");

int[] GetRandomArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int CountEl(int[] arr, int numFrom, int numTo){
    int count = 0;
    foreach(int el in arr){
        if (numFrom <= el && el <= numTo) count++;
    }
    return count;
}

/* Задача 37:Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21
*/

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.WriteLine($"[{String.Join(", ", baseArray)}]");
Console.WriteLine($"Произведение пар чисел: [{String.Join(", ", ResultArray(baseArray))}]");

int[] GetArrayFromString(string stringArray){
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];

    for(int i = 0; i < numbers.Length; i++){
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int[] ResultArray(int[] array)
{
    int size = (array.Length + 1)/ 2;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++){
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}
