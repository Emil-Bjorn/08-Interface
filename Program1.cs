using System;

namespace _08_Interface;

public class Program1 : IStartable, IEndable
{
    /*public void Run()
    {
        Console.WriteLine("Nu kör vi program 1");
    }*/

    public void Start()
    {
        Console.WriteLine("Nu kör vi program 1");
    }

    public void End()
    {
        Console.WriteLine("Nu slutar program 1");
    }
}
