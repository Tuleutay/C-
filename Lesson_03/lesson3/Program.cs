//======== Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- я думаю, - сказал князь, улыбаясь, - что, " 
            + "ежели бы вас послали вместо нашего милого Винценгероду,"
            + "вы бы взяли с присткполдва согрвпыодл выполлвдпьссв клопдв. "
            + " Вы так - вызплзсм. чсыфпд -ызлдаьывлмсчсыуьщплацжсК.";


// string s = "qwerty"
 //              01234
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++) 
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;

}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);