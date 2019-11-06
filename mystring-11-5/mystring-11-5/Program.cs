using System;
using static System.Console;

namespace mystring_11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mystring mystring = new Mystring();
            string str = "aaahuseyn memmedliaaaADD";
            mystring.Str = str;
            //WriteLine(mystring.Insert(0,"SALAM "));
            //WriteLine(mystring.Remove(6));
            //WriteLine(mystring.Remove(5, 8));
            //WriteLine(mystring.PadLeft(20, 'a'));
            //WriteLine(mystring.PadRight(20, 'a'));
            //WriteLine(mystring.StartsWith("Huseyn"));
            //WriteLine(mystring.EndsWith("dlis"));
            //WriteLine(mystring.Replace("seyn", "adam"));
            //WriteLine(mystring.LastIndexOf('e'));
            //WriteLine(mystring.Trim('a'));
            WriteLine(mystring.ToLower());

            Console.ReadKey();
        }
    }
}
