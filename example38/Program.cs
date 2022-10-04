/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
double DifferenceElementsArray(int[] incomingArray)
{
    double min = incomingArray[0];
    double max = incomingArray[0];

    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > max)
            {
            max = incomingArray[i];
            }
        if (incomingArray[i] < min)
            {
            min = incomingArray[i];
            }
    }
    return max - min;
}
int[] currentArray = getRandomArray(5, 10, 100);
printArray(currentArray);
double result = DifferenceElementsArray(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {result}");