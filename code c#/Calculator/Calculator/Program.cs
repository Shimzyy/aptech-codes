// See https://aka.ms/new-console-template for more information
char more = 'y';
while (more == 'y')
{
    Console.WriteLine("Hello, this is calculator ");
    Console.WriteLine("What operation do you want?:\n");
    Console.WriteLine(" 1-Addition\n 2-Subtraction\n 3-multiplication\n 4-division\n 5-exponent\n");
    int decision = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You've selected: " + decision);
    double a, b, c;
    if (decision == 1)
    {
        Console.WriteLine("You have chosen Addition");

        Console.WriteLine("please enter the numbers you want to add");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        Console.WriteLine("your result is: " + c);
    }
    if (decision == 2)
    {
        Console.WriteLine("You have chosen Subtraction");

        Console.WriteLine("please enter the numbers you want to subtract");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a - b;
        Console.WriteLine("your result is: " + c);
    }
    if (decision == 3)
    {
        Console.WriteLine("You have chosen Multiplication");

        Console.WriteLine("please enter the numbers you want to multiply");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a * b;
        Console.WriteLine("your result is: " + c);
    }
    if (decision == 4)
    {
        Console.WriteLine("You have chosen Division");

        Console.WriteLine("please enter the numbers you want to divide");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a / b;
        Console.WriteLine("your result is: " + c);
    }
    if (decision == 5)
    {
        Console.WriteLine("You have chosen Exponentials");

        Console.WriteLine("please enter the numbers you want to exponent");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Math.Pow(a, b);
        Console.WriteLine("your result is: " + c);
    }

    if (decision > 5) 
    { Console.WriteLine("\nincorrect syntax"); }


    Console.WriteLine("\nDo you want to continue? Y/N");
    more = Convert.ToChar(Console.ReadLine());
    continue;
        }

Console.WriteLine("\nsee ya....")

;