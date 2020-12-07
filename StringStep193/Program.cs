using System;
using System.Text;

namespace StringStep193
{
    class Program
    {
        static void Main()
        {
            //string name = "jesse";
            //string quote = "the man said,\"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab ";
            //string fileName = "C:\\Users\\Jesse";
            //string fileName1 = @"C:\Users\Jesse";
            //string fileName3= "C:\\Users||Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(fileName3);
            //Console.Write(quote);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "jesse";
            //name = "joe";

            //StringBuilder sb = new StringBuilder();
            //sb.Append("my name is Jesse");

            //Console.WriteLine(name);
            //Console.WriteLine(sb);
            //Console.ReadLine();


            Console.WriteLine("what is your first name");
            string fName = Console.ReadLine();
            Console.WriteLine("what is your middle name");
            string mName = Console.ReadLine();
            Console.WriteLine("what is your last name");
            string lName = Console.ReadLine();

            string totalName = fName + mName + lName;
            totalName = totalName.ToUpper();

            Console.WriteLine("your first name is: " + fName + "\nmiddle name is: " + mName + "\nand last name is: " + lName);

            Console.WriteLine(totalName);

            StringBuilder sb = new StringBuilder("There are dogs barking outside?");
            sb.Append(" 10 Minuets Later.........!");

            sb.Insert(58, ".... After 10 minuets they are quiet now!.");
            sb.Replace('?', '!');

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}