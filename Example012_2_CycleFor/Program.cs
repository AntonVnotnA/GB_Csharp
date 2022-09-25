Console.Clear();

string Method4(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(4, "Method4 - Hello, World! ");
Console.Write(res);