using System;

public class Hamster : IAnimal
{
    public string Name { get; set; }
    public string Eat()
    {
       return "carrot";
    }

    public void MakeNoise()
    {
        Console.WriteLine(Name + " chitz-chitz");
    }
}