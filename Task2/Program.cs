/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
Алгоритм:
1. Метод: Принимаем на вход данные от пользователя
2. Метод: Ищем точку пересечения
*/

//Принимаем число на ввод
int GetNumber(string message) {
    bool isNumber = false;
    int Number = 0;
    while(!isNumber) {
        Console.Write(message);
        string input = Console.ReadLine();
        if(Int32.TryParse(input, out Number)) {
            isNumber = true;
        }
        else {
            Console.WriteLine("Вы ошиблись при вводе. Введите число.");
        }
    }
    return Number;
}

//Ищем точку пересечения
void FindCrossPoint(double b1, double k1, double b2, double k2) {
    // y = k1 * x + b1, y = k2 * x + b2;
    // 0 = k1 * x + b1 - (k2 * x + b2);
    // 0 = k1 * x + b1 - k2 * x - b2;
    // 0 = (k1 - k2)*x + b1 - b2;
    // b2 - b1 = (k1 - k2)*x;
    // x = (b2 - b1) / (k1 - k2);
    // y = k2 * x + b2
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine($"x = ({b2} - {b1}) / ({k1} - {k2})");
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}

int b1 = GetNumber("Введите b1: ");
int k1 = GetNumber("Введите k1: ");
int b2 = GetNumber("Введите b2: ");
int k2 = GetNumber("Введите k2: ");
FindCrossPoint(b1, k1, b2, k2);
