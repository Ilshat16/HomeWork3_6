// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Методы.
int[] EnterNums(int length)
{
    Console.WriteLine($"Введите {length} чисел");
    int[] numsArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        int number = int.Parse(Console.ReadLine());
        numsArray[i] = number;
    }
    return numsArray;
}

int CountingPositivNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}
// Создание массива из М чисел.
Console.Write("Введите число: ");
int length = int.Parse(Console.ReadLine());
int[] array = EnterNums(length);
// Подсчет количества чисел больше 0.
int result = CountingPositivNumbers(array);
// Вывод результата.
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"{result} чисел больше 0");