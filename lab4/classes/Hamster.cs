using System;

public class Hamster : AnimalBase, IAnimal
{
    public string Name { get; set; }

    public override void Bites()
    {
        Console.WriteLine("Fatal bite");
    }

    public string Eat()
    {
       return "carrot";
    }

    public void MakeNoise()
    {
        Console.WriteLine(Name + " chitz-chitz");
    }
}