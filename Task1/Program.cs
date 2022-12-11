/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
Алгоритм:
1. Спрашиваем пользователя, сколько чисел он хочет ввести. 
2. Создаём пустой массив с кол-вом элементов из п.1
3. Заполняем значения в массиве из ввода пользователя.
4. Считаем кол-во чисел больше 0 в массиве.
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

//выводим числа в массиве на экран (для проверки)
void PrintArray (int [] targetArray) {
    int len = targetArray.Length;
    string result = "[";
        for (int i = 0; i < len - 1; i++) {
        result += $"{targetArray[i]}, ";
        }
    result += targetArray[len-1] + "]";
    Console.WriteLine(result);
}

//Заполняем значения массива из ввода пользователя

int [] FillArray(int [] targetArray) {
    for (int i = 0; i <targetArray.Length; i++) {
        targetArray[i] = GetNumber($"Введите число {i+1}: ");
    }
    return targetArray;
}

//Показываем кол-во чисел больше 0 в массиве

void ShowNumbersAboveZero(int [] targetArray) {
    int result = 0;
    for (int i = 0; i < targetArray.Length; i++) {
        if (targetArray[i] > 0) result ++;
    }
    Console.WriteLine ($"В массиве {result} чисел больше 0.");
}

int numElements = GetNumber("Сколько чисел будет в массиве? "); // п.1 алгоритма
int [] userArray = new int [numElements]; //п.2 алгоритма
FillArray(userArray); //п.3 алгоритма
PrintArray(userArray); // проверяем, что п.3 отработал как надо
ShowNumbersAboveZero(userArray); // п. 4 алгоритма 
