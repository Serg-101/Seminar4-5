/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] GetNumbers() //вводим целолые числа с консоли через пробел и парсим строку с преобразованием в int 
{
    string[] numbers = Console.ReadLine().Split(' ');
    int[] value = new int[numbers.Length];
    int i = 0;
    foreach (var item in numbers) value[i++] = int.Parse(item);
    return value;
}

int GetPositiveNumbers(int[] numbers)  // находим положительные числа среди представленных
{
    int countPositiveNumbers = 0;
    foreach (var item in numbers) if (item > 0) countPositiveNumbers++;
    return countPositiveNumbers;
}

void PrintResult(int countPositiveNumbers) //  выводим результат в правильном виде
{
    if (countPositiveNumbers == 0)
        System.Console.WriteLine("положительные числа не найдены");
    else if (countPositiveNumbers == 1)
        System.Console.WriteLine("Найдено одно число");
    else if (countPositiveNumbers > 1 && countPositiveNumbers < 5)
        System.Console.WriteLine($"Найдено {countPositiveNumbers} положительных числа среди введенных ранее.");
    else 
        System.Console.WriteLine($"Найдено {countPositiveNumbers} положительных чисел среди введенных ранее.");
}

Console.Clear();
System.Console.WriteLine("Введите через пробел несколько чисел, что бы подсчитать не  отрицательных чисел");
System.Console.WriteLine("Например  0 7 8 -2 -2");
int[] numbers = GetNumbers();
int countPositiveNumbers = GetPositiveNumbers(numbers);
PrintResult(countPositiveNumbers);
