// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] getArray(int size)
{
    int[] array = new int[8];
    array = new Random().Next();
    return array;
}

System.Console.WriteLine("["+string.Join(", ", array)+"]");