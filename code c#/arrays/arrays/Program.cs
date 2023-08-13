// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
//ARRAY EXAMPLE 1
/*string[] Names = new string[] {"Hamzah","Tega","Pelumi","Bright","Giyatha"};
for(int i= 0; i<Names.Length; i++)
{
    int rank = i + 1;
    Console.WriteLine(rank + "-my classmates are: "+ Names[i]);
    
}*/

//ARRAY EXAMPLE 2
/*string[] stuff = new String[3];
Console.WriteLine("what do you want?\n");

for (int i = 0; i < stuff.Length; i++)
{
    stuff[i] = Console.ReadLine();
}

Console.WriteLine("\nThis is the shit you want?");

Array.Sort(stuff);
for (int i=0;i<stuff.Length;i++)
{
    Console.WriteLine(stuff[i]);
}*/

//EXAMPLE ON LISTS
/*List<string> bababooey = new List<string>();
bababooey.Add("eggs1");
bababooey.Add("eggs2");
bababooey.Add("eggs3");

for (int i = 0; i < bababooey.Count; i++)
{
    Console.WriteLine(bababooey[i]);
}
bababooey.RemoveAt(2);
Console.WriteLine("------------------------");
for (int i = 0; i < bababooey.Count; i++)
{
    Console.WriteLine(bababooey[i]);
}*/

//ARRAY EXAMPLE 3
/*int std;
Console.WriteLine("How many students are in your class?");
std=Convert.ToInt32(Console.ReadLine());

string[] studNames = new string[std];
Console.WriteLine("Please enter their names");
for (int i = 0; i < studNames.Length; i++)
{
    studNames[i] = Console.ReadLine();
}
Console.WriteLine("\nyour students are: ");

Array.Sort(studNames);
for (int i = 0; i < studNames.Length; i++)
{
    Console.WriteLine(studNames[i]);
}*/

int[,] poop = new int[2, 2]
{
 {2,3},
 {4,5}
};

    {
Console.WriteLine(poop[0,1]);
    }
//JAGGED ARRAY EXAMPLES: 
//1
string[][] jagged = new string[3][];
jagged[0] =new string[]{ "joffy", "jeff", "eddward" };
jagged[1] =new string[3];
jagged[2] = new string[1];

jagged[1][2] = "greg";
Console.WriteLine(jagged[0][1]);
Console.WriteLine(jagged[1][2]);

//2
string[][] companies = new string[3][];
companies[0] = new string[]{"Intel", "AMD"};
companies[1] = new string[] { "IBM", "MIcrosoft", "Sun" };
companies[2] = new string[] {"HP","Canon","Lexmark","Epson"};

for (int i = 0; i < companies.Length; i++)
{
    Console.WriteLine("\n------------------------------\n"+"for the companies in group " + (i + 1) + ":\t");
    /*for (int j = 0; j < companies[i].Length; j++)
    {
        Console.WriteLine(companies[i][j]);
    }*/
    foreach (var s in companies[i])
    {
        Console.WriteLine(s);
    }
}



Console.WriteLine("\nPress any key to continue");
Console.ReadKey();

