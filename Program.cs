int GetNewCount(string[] array)
{
    int newCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newCount++;
        }
    }
    return newCount;
}

string[] GetNewArray(string[] array)
{
    string[] newArr = new string[GetNewCount(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[j++] = array[i];
        }
    }
    return newArr;
}

string[] CreateArray(int countElement)
{
    string[] array = new string[countElement];
    for (int i = 0; i < countElement; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string OutputArray(string[] array)
{
    string outputString = "[";
    for(int i=0; i<array.Length;)
    {
        outputString += $"{array[i]}";
        if(++i<array.Length)
        {
            outputString += ", ";
        }
    }
    return outputString += "]";
}

Console.Write("Введите количество элементов в массиве: ");
int count = Int32.Parse(Console.ReadLine());
Console.WriteLine("Построчно введите элементы массива:");
string[] oldArr = CreateArray(count);
string[] newArr = GetNewArray(oldArr);
Console.WriteLine($"Результат: {OutputArray(newArr)}");

