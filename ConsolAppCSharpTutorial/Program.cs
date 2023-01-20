using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppCSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable in c#-type of vaiables
            //constant example
            const int myNunber = 15;
            Console.WriteLine(myNunber);
            //DISPLAY VARIABLE-EXAMPLE
            string name = "DEV";
            string lastName = "sharma";
            Console.WriteLine( name+lastName);
            //multiple variable-example
            int x = 6, y = 8, z = 20;
            Console.WriteLine(x + y + z);
            //c# identifier-example
            int minutePerHour = 60;
            int secondPerMinute = 60;
            Console.WriteLine(minutePerHour);
            Console.WriteLine(secondPerMinute);
            //c# datatype example
            // int myNum = 5;
            // double myDoubleNum = 4.67;
            // char myLetter = 'a';
            // string myText = "hello";
            // bool myBool = true;
            // operator in c# four type
            //1 Arithmetic operator- (-,+,*,/,%,++,--)example
            int x1 = 10 + 5;
            Console.WriteLine(x1);
            int y1 = 230 - 45;
            Console.WriteLine(y1);
            //2 Assignment operator- (=,+=,-=,*=,/=,&=,|=,>>=,<<=,%=)
            int x2 = 10;
            x2 += 5;
            Console.WriteLine(x2);
            //3 Comparison operator- (==,>,<,=>,<=,!=)
            int a = 34;
            int b = 56;
            Console.WriteLine(a > b);
            //4 Logical operator- (&&,!,||)
            int a1 = 34;
            Console.WriteLine(a1 > 10 && a1 < 5);
            //C# math
            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(10, 20));
            //string in c#
            //string text1 = "hello";
            //string text2 = "i am fine";
            //Console.WriteLine(text1+ text2);
            //Console.WriteLine(text1.Length);
            //Console.WriteLine(text1.ToUpper());
            string firstName = "Dev";
             lastName  = "Sharma";
            name  = firstName + lastName;
            Console.WriteLine(name);
            int a2 = 5;
            int b2 = 7;
            int c = a2 + b2;
            Console.WriteLine(c);
            //string interpulation
            string myfirstName = "dev";
            string mylastName = "sharma";
            string myname = $"my name is :{myfirstName}{mylastName}";
            Console.WriteLine(myname);
            //string access
            string myString = "hello";
            Console.WriteLine(myString[3]);
            Console.WriteLine(myString.IndexOf("l"));
            string fullName = "dev sharma";
            int charPos = fullName.IndexOf("h");
            Console.WriteLine(charPos);
            //string special-character
            string txt = "we are the so called\"viking\" from the north";
            Console.WriteLine(txt);
            //BOOLEAN VALUE
            bool myName = true;
            bool myhome = false;
            Console.WriteLine(myName);
            Console.WriteLine(myhome);
            int xa = 10;
            int ya = 20;
            Console.WriteLine(ya > xa);
            Console.WriteLine(10 == 15);
            Console.WriteLine(10 >= 15);
            Console.WriteLine(10 <= 15);
            int myage = 25;
            int votingAge = 18;
            if(myage > votingAge)
            {
                Console.WriteLine("this is a voting age :"+votingAge);
            }
            Console.ReadLine();
        }
    }
}
