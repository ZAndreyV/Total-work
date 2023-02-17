const int length = 4; // Создаём константу,чтобы в коде не было magig numbers.

int GetArrayLengthFromUser()
{
    int lengthArray = 0; 
    while(lengthArray < 1) 
    {
    try // код в котором может быть ошибка
        {   
            Console.Write("Enter the length of the array:  "); // спрашиваем длину массива
            lengthArray = Convert.ToInt32(Console.ReadLine()); 

            if(lengthArray < 1) Console.WriteLine("The entered value is less than one, please try again"); // начинаем заново
        }
    catch (System.FormatException) // в случае ошибки
        {
            Console.WriteLine("You didn't enter a number, let's try again"); // выводим сообщение
        }
    }
     return lengthArray;
}


string[] CreatArrayRndStr(int len)                      // создаем метод
{
    string[] arr = new string[len];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter array element at number {i + 1}: ");
        string? text = Console.ReadLine();
        
        if (text == null) arr[i] = string.Empty;
        else arr[i] = text;
    }
    return arr;                                         // возвращаем результат
}


void PrintArray(string[] arr)                            // объявляем метод
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null)                             // выводим только в случае если массив не пустой
        {
            if(i < arr.Length - 1) Console.Write($"\"{arr[i]}\", "); 
            else Console.Write($"\"{arr[i]}\"");        // последняя строка без запятой
        }
    }
    Console.Write("]");
}


string[] SortArrayStr(string[] arr)
{
   string[] arr1 = new string[arr.Length];               // создаем новый массив с такой же длинной
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < length) arr1[i] = arr[i];    // если условия соблюдены, записываем
    }
    return arr1;                                         // возврат
}

string[] arrayStr = CreatArrayRndStr(GetArrayLengthFromUser());
Console.WriteLine(string.Empty);
PrintArray(arrayStr);
Console.Write(" -> ");
string[] sortArray = SortArrayStr(arrayStr);
PrintArray(sortArray);