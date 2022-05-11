using System;
using System.Text;

namespace QT
{
    class Program
    {
        static StringBuilder sb = new StringBuilder("Hello my name is QT");
        
        static void InterationExample()
        {
            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]); // output: Hello World!
        }
        static void RetrieveString()
        {
            var greet =sb.ToString();
            Console.WriteLine(greet);
        }
        static void AddString(string AdditionString1,string AdditionString2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AdditionString1);
            sb.Append(" ");
            sb.AppendLine(AdditionString2);
            Console.WriteLine(sb);
        }
        static void InsertString(int index, string stringToInsert)
        {
            sb = new StringBuilder("Hi, i'm a super bot");
            sb.Insert(index, stringToInsert);
            Console.WriteLine(sb);
        }
        static void Main(string[] args)
        {

            //InterationExample();
            //RetrieveString();
            AddString("hi", "This is QT");
            InsertString(2, " QT");
            
        }
    }
}