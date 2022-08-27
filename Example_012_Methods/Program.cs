// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();

// Вид 2  Ничего не принимают, но могут возвращать какие-то элементы:
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

//или

//void Method21(string msg, int count)
//{
//   int i = 0;
//   while (i < count)
//   {
//       Console.WriteLine(msg);
//        i++;
//    }

//}
//Method21(msg: "Текст", 4);
//или
//Method21(count: 4, msg: "Новый текст");

// Вид3: Методы, которые что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

//Вид4: Методы, которые что-то принимают и что-то возвращают.

//string Method4(int count, string c)
//{
//    int i = 0;
//    string result = String.Empty;

//    while (i < count)
//    {
//        result = result + c;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);

//или же через for

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);