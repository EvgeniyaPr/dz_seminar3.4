// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int InputNumber(string str)                 
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}   

// System.Console.Write(Math.Pow(A, B));

int cube(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

bool Validator(int numB)
{
    if(numB < 1)
    {
        System.Console.WriteLine("Введите число больше нуля");
        return false;
    }
    return true;
}

int numA = InputNumber("Введите число А: ");
int numB = InputNumber("Введите число B: ");
if(Validator(numB))
{
System.Console.WriteLine($"Число {numA} в степени {numB} равно {cube(numA,numB)}");
}