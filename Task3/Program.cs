/*
Напишите программу,
которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

//Создаём массив случайных чисел от 0 до 999 из кол-ва элементов от 1 до 10
int [] CreateRandomArray() {
    Random rnd = new Random();
    int NumElements = rnd.Next(0,11);
    int [] randArray = new int [NumElements];
    for (int i = 0; i < NumElements; i++) {
        randArray [i] = rnd.Next(0, 1000);
    }
    return randArray;
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

//копируем массив поэлементно
int [] CopyArray (int [] targetArray) {
    int [] resultArray = new int [targetArray.Length];
    for (int i = 0; i < resultArray.Length; i++) {
        resultArray[i] = targetArray[i];
    }
    return resultArray;
}

int [] sourceArray = CreateRandomArray();
int [] clonedArray = CopyArray(sourceArray);
Console.Write("Исходный массив: ");
PrintArray(sourceArray);
Console.Write("Скопированный массив: ");
PrintArray(clonedArray);