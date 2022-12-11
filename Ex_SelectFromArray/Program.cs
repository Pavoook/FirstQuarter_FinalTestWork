string[] inputArray = { "hello", "2", "world", ":-)" };
SelectFromArray(inputArray);

string[] inputArray2 = { "1234", "1567", "-2", "computer science" };
SelectFromArray(inputArray2);

string[] inputArray3 = { "Russia", "Denmark", "Kazan" };
SelectFromArray(inputArray3);


void SelectFromArray(string[] array)
{
    Console.Write("Задан массив строк: ");
    PrintArray(array);
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
        Console.Write("Отсортированный массив: ");
        PrintArray(selectedArray);
        Console.WriteLine();
    }
    else
    {
        string[] selectedArray = new string[counter];
        for (int i = 0; i < counter; i++)
        {
            selectedArray[i] = array[tempArray[i]];
        }
        Console.Write("Отсортированный массив: ");
        PrintArray(selectedArray);
        Console.WriteLine();
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