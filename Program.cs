namespace _08_Interface;

class Program
{
    static void Main(string[] args)
    {
        IStartable progam1 = new Program1();
        IStartable program2 = new Program2();

        /*progam1.Run();
        program2.Go();*/

        IStartable[] startables = [progam1, program2];

        // Polymorphism with interfaces
        foreach (IStartable startable in startables)
        {
            startable.Start();
        }

        ((Program1)progam1).End();
    }
}
