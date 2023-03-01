using System;

namespace TMSLesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Credentials.IsValid("morethantwentysymbols", "123qweASD", "123qweASD")) Console.WriteLine("Все ОК");
            if (Credentials.IsValid("login with spaces", "123qweASD", "123qweASD")) Console.WriteLine("Все ОК");
            if (Credentials.IsValid("login", "morethantwentysymbols", "123qweASD")) Console.WriteLine("Все ОК");
            if (Credentials.IsValid("login", "pass word", "123qweASD")) Console.WriteLine("Все ОК");
            if (Credentials.IsValid("login", "withoutdigits", "123qweASD")) Console.WriteLine("Все ОК");
            if (Credentials.IsValid("login", "123qweASD", "123QWEasd")) Console.WriteLine("Все ОК");
            if (Credentials.IsValid("login", "123qweASD", "123qweASD")) Console.WriteLine("Все ОК");
        }
    }
}