// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Методы.
void FindingIntersectionPoint(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    Console.WriteLine($"Точка перечечения данных функций: х = {x}, y = {y}");
}

int EnterNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
// Ввод постоянных чисел уравнений
Console.WriteLine("Даны уравнения  y = k1 * x + b1, y = k2 * x + b2");
int k1 = EnterNumber("Введите число k1: ");
int b1 = EnterNumber("Введите число b1: ");
int k2 = EnterNumber("Введите число k2: ");
int b2 = EnterNumber("Введите число b2: ");
// Нахождение точки пересечения уравнений y = k1 * x + b1, y = k2 * x + b2
FindingIntersectionPoint(k1, b1, k2, b2);