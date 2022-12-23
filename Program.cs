//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше
//0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
int [] PositiveNumbers(int size){
    int [] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i} ");
       arr[i]  = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int Even (int [] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
       if (arr[i] > 0){
        count += 1;
       } 
    }
    return count;  
}
Console.WriteLine($" Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = PositiveNumbers(size );
Console.WriteLine($"Количество четных чисел {Even(array)} ");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
void IntersectionPoint(float k1, float k2, float b1, float b2){
    float x = -(b1 - b2) / (k1 - k2);
    float y = k1 * x + b1;
    
    
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
Console.WriteLine($"Введите значение k1 ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение k2 ");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение b1 ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение b2 ");
float b2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(k1, k2, b1, b2);
*/