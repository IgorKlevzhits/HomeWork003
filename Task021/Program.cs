/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double[] arrayFilling(double[] array)//Автоматическое заполнение массива для удобства
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

//Поиск расстояния между двумя точками в 3D пространстве
double findDictanseBetweenPoints(double[] coordinatesFirstPoint, double[] coordinatesSecondPoint)
{
    double result = 0;
    for (int i = 0; i < coordinatesFirstPoint.Length; i++)
    {
        result += (coordinatesFirstPoint[i] - coordinatesSecondPoint[i]) * (coordinatesFirstPoint[i] - coordinatesSecondPoint[i]);
    }
    return result = Math.Sqrt(result);
}

//если нужно проверить ручным вводом, закоментируйте 29-32 строки, и раскомментируйте 34-35
double[] coordinatesFirstPoint = new double[3];
coordinatesFirstPoint = arrayFilling(coordinatesFirstPoint);
double[] coordinatesSecondPoint = new double[3];
coordinatesSecondPoint = arrayFilling(coordinatesSecondPoint);

//double[] coordinatesFirstPoint = new double[3] {3, 6, 8};
//double[] coordinatesSecondPoint = new double[3] {2, 1, -7};

Console.WriteLine("Расстояние между точкой ");
Console.WriteLine($"А({coordinatesFirstPoint[0]}, {coordinatesFirstPoint[1]}, {coordinatesFirstPoint[2]})");
Console.WriteLine("и точкой ");
Console.WriteLine($"B({coordinatesSecondPoint[0]}, {coordinatesSecondPoint[1]}, {coordinatesSecondPoint[2]})");
Console.WriteLine($"равно - {findDictanseBetweenPoints(coordinatesFirstPoint, coordinatesSecondPoint)}");
