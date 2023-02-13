/* Задача 35: Задайте одномерный массив из 123 случайных чисел [0: 1000].
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/

Console.Clear();
int[] array = GetRandomArray();
Console.WriteLine($"Массив из 123 элементов: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {CountEl(array)}");

int[] GetRandomArray(){
    int size = 123;
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(0, 1000);
    }
    return result;
}

int CountEl(int[] arr){
    int count = 0;
    foreach(int el in arr){
        if (10 <= el && el <= 99){
            count++;
        }
    }
    return count;
    
}