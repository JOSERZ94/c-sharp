using System;

public abstract class Reptiles: Animal
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine("Arrastrandose...");
    }



    public void nadar()
    {
        Console.WriteLine("Nadando...");
    }
}