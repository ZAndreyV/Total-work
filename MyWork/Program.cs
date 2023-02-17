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