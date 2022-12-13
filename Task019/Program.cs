/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
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

bool isItPalindrome(int number) //Проверка является ли число палиндромом
{
    string checkPalindrome = Convert.ToString(number);
    for (int i = 0; i <= checkPalindrome.Length / 2; i++)
    {
        int j = checkPalindrome.Length - 1 - i;
        if (checkPalindrome[i] != checkPalindrome[j])
            return false;
    }
    return true;
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
if (checkInput(input)) //Если данные введены корректно
{
    int number = int.Parse(input);
    if (isItPalindrome(number))
        Console.WriteLine($"Число {number} - является палиндромом!");
    else
        Console.WriteLine($"Число {number} - не является палиндромом!");

}