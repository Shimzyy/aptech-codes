using System;

namespace delegates
{
    /*class Mathmatics
    {
        static int Addition(int numone, int numtwo)
        {
            return (numone + numtwo);
        }

        static int Subtraction(int numone, int numtwo) 
        { return (numone - numtwo); }
       
}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }*/

    /*public delegate void Messenger(int value);
    class CompositeDelegates
    {
        static void EvenNumber(int value)  
        {
            Console.WriteLine("Even Numbers: ");
            for (int i = 2; i <= value; i+=2)
            {
                Console.WriteLine(i + " ");
            }
        }

        void OddNumbers(int value)
        {
            Console.WriteLine();
            Console.WriteLine("Odd numbers: ");
            for (int i = 1; i <= value; i+=2)
            {
                Console.WriteLine(i + " ");
            }
        }

        static void start (int number)
        {
            CompositeDelegates objComposite = new CompositeDelegates();
            Messenger objDisplayOne = new Messenger(EvenNumber);
            Messenger objDisplayTwo = new Messenger
                (objComposite.OddNumbers);
            Messenger objDisplayComposite = 
            (Messenger)Delegate.Combine(objDisplayOne,objDisplayTwo);
            objDisplayComposite(number);
            Console.WriteLine();
            object obj = objDisplayComposite.Method.ToString();
            if (obj != null)
            {
                Console.WriteLine("The delegate invokes an instance method: " + obj);
            }
            else
            {
                Console.WriteLine("The delegate invokes only static methods");
            }
        }*/

    public class ConvertString;
     delegate string MakerUpper(string s);
     

        public static void Main(string[] args)
        {
        MakerUpper con = word = word.ToUpper();
        Console.WriteLine(con("abc"));
    }
    }

}
