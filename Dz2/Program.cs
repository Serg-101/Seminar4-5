/*
Задача 43. Напишите программу, 
которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
вероятно опечатка в задании.
*/

float GetNumber(string message) //ввод целолго числа с консоли с проверкой
{
    System.Console.Write(message);
    while (true)
        if (float.TryParse(Console.ReadLine(), out float result))
            return result;
        else
            System.Console.WriteLine("Ошибка,  введите число");
}

float GetCoordinateX(float b1, float k1, float b2, float k2) // вычесление координаты x через систему уравнений
{
    return (b2 - b1) / (k1 - k2);
}

float GetCoordinateY(float coordinateX, float b1, float k1) // подставляем координату x и вычисляем y
{
    return (k1 * coordinateX + b1);
}

Console.Clear();
System.Console.WriteLine("Найти точку пересечения двух прямых заданных формулой y=kx+b");
float b1 = GetNumber("Введите b1 = ");
float k1 = GetNumber("Введите k1 = ");
float b2 = GetNumber("Введите b2 = ");
float k2 = GetNumber("Введите k2 = ");
float coordinateX = GetCoordinateX(b1, k1, b2, k2);
float coordinateY = GetCoordinateY(coordinateX, b1, k1);
System.Console.WriteLine($"Координаты пересечения (X={coordinateX}; Y={coordinateY})");

/*
а могло бы быть короче
float x = (b2 - b1) / (k1 - k2);
float y = (k1 * x + b1);
Console.WriteLine($"Координаты пересечения (X={x}; Y={y})");
/*