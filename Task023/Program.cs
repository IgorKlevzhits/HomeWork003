/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
bool checkInput(string input) //Функция проверки корректности введенных данных
{
    int number;
    if (int.TryParse(input, out number))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Данные введены некорректно!");
        return false;
    }
}

int[] createCubeTable(int number)
{
    int[] cubeTable = new int[number];
    int j = 0;
    for (int i = 0; i < cubeTable.Length; i++)
    {
        j = j + 1;
        cubeTable[i] = j * j * j;
    }
    return cubeTable;
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
if (checkInput(input)) //Если данные введены корректно
{
    int number = int.Parse(input);
    if (number > 0)
    {
    int[] cubeTable = createCubeTable(number);
    Console.Write("Таблица кубов: ");
    for (int i = 0; i < cubeTable.Length - 1; i++)
    {
        Console.Write($"{cubeTable[i]}, ");
    }
    Console.WriteLine($"{cubeTable[cubeTable.Length - 1]}");
    }
    else if (number == 0)
        Console.WriteLine("Число не должно быть равно нулю!");
    else
        Console.WriteLine("Число не должно быть отрицательным!");
}