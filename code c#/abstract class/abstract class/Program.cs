// See https://aka.ms/new-console-template for more information
/*abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every animal eats food in order to survive");
    }
    public abstract void Animalsound();

};
class Lion : Animal
{
    public override void Animalsound()
    {
        Console.WriteLine("Lions roar");

    }
    static void Main (string[]args)
    {
        Lion objLion = new Lion();
        objLion.Animalsound();
        objLion.Eat();
    }
}*/
interface IAnimal
{
    void animalSound();
}

class Pig : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: oink");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();
    }
}
