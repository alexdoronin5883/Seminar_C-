// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

//Решение//////////////////////////////////////////////////////

// Console.Write("Введите числа(через запятую): ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Количество чисел больше 0: {count}");



/////////////////////////////////////////////////////////////////

// Задача 43: 
// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Решение//////////////////////////////////////////////////////
// x = (b1-b2)/(k2-k1)

// y = (k2*b1-k1*b2)/(k2-k1)

// double b1 = Convert.ToInt32(Console.Read());
// double b2 = Convert.ToInt32(Console.Read());
// double k1 = Convert.ToInt32(Console.Read());
// double k2 = Convert.ToInt32(Console.Read());

// double y = (k2 * b1 - k1 * b2)/(k2 - k1);
// double x = (b1 - b2) / (k2 - k1);


// Console.WriteLine($"Координаты точки пересечения X: {x}");
// Console.WriteLine($"Координаты точки пересечения Y: {y}");




/////////////////////////////////////////////////////////////////