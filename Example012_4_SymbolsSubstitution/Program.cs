// Заменить все пробелы в тексте на | , заменить некоторые большие буквы на маленнькие и наоборот

using static System.Console;
Clear();

string text = "Hello World";

string ReplaceText(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
} 

string newText = ReplaceText(text, ' ', '|');
WriteLine(newText);
WriteLine();
newText = ReplaceText(newText, 'l', 'L');
WriteLine(newText);
WriteLine();
WriteLine(ReplaceText(newText, 'W', 'w'));