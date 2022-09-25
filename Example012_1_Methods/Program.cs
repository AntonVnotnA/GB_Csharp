Console.Clear();

// Method1: xIN & xOUT => void

void Method1()
{
    Console.WriteLine("Method1 - Hello, World!");
}

// Method2: IN & xOUT => void

void Method21(string message)
{
    Console.WriteLine(message);
}

void Method22(string message, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.Write($"{message} ");
        i++;
    }
}

// Method3 : xIN & OUT 

int Method3()
{
    return DateTime.Now.Year;
}


// Method4 : IN & OUT

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}


// Recall all methods

Method1();

Method21("Method2.1 - Hello, World!");
Method21(message: "Method2.1 - Hello, World!");
Method22("Method2.2 - Hello, World!", 4);
Console.WriteLine();
Method22(message: "Method2.2 - Hello, World!", count: 4);
Console.WriteLine();
Method22(count: 4, message: "Method2.2 - Hello, World!");
Console.WriteLine();

int year = Method3();
Console.WriteLine($"Method3 - year={year}");

string res = Method4(10, "Method4 - Hello, World! ");
Console.Write(res);