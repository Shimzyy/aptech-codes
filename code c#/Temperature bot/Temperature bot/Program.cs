// See https://aka.ms/new-console-template for more information
char yup = 'n';
    while (yup == 'n') {
Console.WriteLine("Hello, i am temperature bot");
Console.WriteLine("please select your preferred unit");
Console.WriteLine("\n1- Celcius(C) \n2-Farenheit(F)");
int decision = Convert.ToInt32(Console.ReadLine());
int temp;

if (decision == 1) 
{
    Console.WriteLine("You have chosen Celcius");
    Console.WriteLine("\nplease input the temperature in celcuis");
    temp = Convert.ToInt32(Console.ReadLine());
    float other_temp = ((temp * (9 / 5)) + 32);
    Console.WriteLine("the temperature in farenheit is:"+other_temp);
        }

if (decision == 2)
{
    Console.WriteLine("You have chosen Farenheit");
    Console.WriteLine("\nplease input the temperature in Farenheit");
    temp = Convert.ToInt32(Console.ReadLine());
    float other_temp = ((temp - 32 ) * (9 / 5));
    Console.WriteLine("the temperature in Celcius is:" + other_temp);
}

Console.WriteLine("Is that all? Y/N");
yup = Convert.ToChar(Console.ReadLine());
}

