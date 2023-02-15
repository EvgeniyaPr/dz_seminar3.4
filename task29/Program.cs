// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[] getArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++)         
    {                                      
        array[i] = new Random().Next(leftRange, rightRange); 
    }
    return array; 
}

void PrintArray(int[] array) 
{
    System.Console.WriteLine("["+string.Join(", ", array)+"]");
}
int arraySize = InputNumber("Введите размер массива: ");
int leftNum = InputNumber("Нижнаяя граница массива: ");
int rightNum = InputNumber("Верхняя граница массива: ");

int[] newArray = getArray(arraySize, leftNum, rightNum);

PrintArray(newArray);

