/*
    Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
    меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
    выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
    исключительно массивами.

    "hello", "2", "world", ":-)"] > ["2", "5-)"]
    ['1234", "1567", "-2", "computer science"] -> ["2"]
    ["Russia", "Denmark", "Kazan"] -> []
*/

Console.WriteLine("Введите количество элементов массива: ");  // Задаём массив
int size = Convert.ToInt32(Console.ReadLine());
string[] one_array = new string[size];


for (int i = 0; i < one_array.Length; i++)                    // Задаём значение всем элементам массива
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    one_array[i] = Convert.ToString(Console.ReadLine());
}


int len = 3;                // Длинна (Сокращённо от length)
int QuantityIndex = 0;      // Количество элементов второго массива

for (int j = 0; j < one_array.Length; j++)                  // Задаём размер второго массива
{
    if (one_array[j].Length <= len)
    {
        QuantityIndex++;
    }
}

string[] second_array = new string[QuantityIndex];          // Задаём второй массив

int len2 = 3;               // Длинна (Сокращённо от length)
int index = 0;              // Элемент второго массива

for (int a = 0; a < size; a++)                              // Находим элементы первого массива, меньше 3 символов
{
    if (one_array[a].Length <= len2)
    {
        second_array[index] = one_array[a];
        index++;
    }
}

void PrintArray(string[] array)                             // Выводим массив
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}



Console.WriteLine();
PrintArray(one_array);
PrintArray(second_array);
Console.WriteLine();