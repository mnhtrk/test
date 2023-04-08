using System;
using System.IO;
using System.Collections.Generic;


StreamReader f = new StreamReader("input.txt");
string s = f.ReadLine();
/*
string s = "";
s = Console.ReadLine();*/
string ans = "";

if (s[0] == Char.ToUpper(s[0]))
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == Char.ToUpper(s[i]))
        {
            if (i != 0)
            {
                ans += "_";
            }
            ans += Char.ToLower(s[i]);
        }
        else
        {
            ans += s[i];
        }
    }
}
else
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == Char.ToLower(s[i]) && (i == 0 || s[i - 1] == '_'))
        {
            ans += Char.ToUpper(s[i]);
        }
        else if (s[i] != '_')
        {
            ans += s[i];
        }
    }
}
/*Console.WriteLine(ans);*/


using (StreamWriter f1 = new StreamWriter("output.txt"))
{
    f1.WriteLine(ans);
}