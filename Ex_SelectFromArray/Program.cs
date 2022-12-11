string[] inputArray1 = { "hello", "2", "world", ":-)" };
Console.Write("Задан массив строк: ");
PrintArray(inputArray1);
string[] resultArray1 = SelectFromArray(inputArray1);
Console.Write("Отсортированный массив: ");
PrintArray(resultArray1);
Console.WriteLine();

string[] inputArray2 = { "1234", "1567", "-2", "computer science" };
Console.Write("Задан массив строк: ");
PrintArray(inputArray2);
string[] resultArray2 = SelectFromArray(inputArray2);
Console.Write("Отсортированный массив: ");
PrintArray(resultArray2);
Console.WriteLine();

string[] inputArray3 = { "Russia", "Denmark", "Kazan" };
Console.Write("Задан массив строк: ");
PrintArray(inputArray3);
string[] resultArray3 = SelectFromArray(inputArray3);
Console.Write("Отсортированный массив: ");
PrintArray(resultArray3);


string[] SelectFromArray(string[] array)
{
    int[] tempArray = new int[array.Length];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            tempArray[counter] = i;
            counter++;
        }
    }
    
    if (counter == 0)
    {
        string[] selectedArray = new string[1];
        return selectedArray;
    }
    else
    {
        string[] selectedArray = new string[counter];
        for (int i = 0; i < counter; i++)
        {
            selectedArray[i] = array[tempArray[i]];
        }
        return selectedArray;
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}