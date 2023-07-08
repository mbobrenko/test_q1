/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами*/

Console.WriteLine("Введите  несколько строк ");
string input = Console.ReadLine();
string[] ExitArray = new string[0];
int Sym = 3;
string[] EnterArray;

EnterArray = matrix(input);

for (int i = 0; i < EnterArray.Length; i++)
{
    if (EnterArray[i].Length <= Sym)
    {
       ExitArray = NewoneArray(ExitArray, EnterArray[i]);
    }
}

PrintSArray(EnterArray);
Console.Write(" --> ");
PrintSArray(ExitArray);
Console.WriteLine();

void PrintSArray(string[] array)
{
    if (array.Length == 0)
        Console.Write("[]");
    else
    {
        Console.Write("(");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
                Console.Write('"' + array[array.Length - 1] + '"' + ")");
            else
                Console.Write('"' + array[i] + '"' + ", ");
        }
    }
}

string[] matrix(string array)
{
    int count = 1;

    for (int m = 0; m < array.Length; m++)
    {
        if (array[m] == ' ')
            count++;
    }

    string[] returnArray = new string[count];
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != ' ')
        {
            returnArray[i] += array[j];
        }
        else
            i++;
    }
    return returnArray;
}

string[] NewoneArray(string[] array, string newElement)
{
    string[] tempArray = new string[array.Length + 1];
    tempArray[tempArray.Length - 1] = newElement;
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = array[i];
    }
    return tempArray;
}


