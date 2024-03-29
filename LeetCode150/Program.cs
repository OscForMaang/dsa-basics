// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string s = "abc";
string t = "ahbgdc";

HashSet<char> chars = new HashSet<char>(t.ToCharArray());

foreach (char ch in s)
{    
    if (!chars.Contains(ch))
    {
        Console.WriteLine("te");
    }
}