namespace _08_Interface;

class Program
{
    static void Main(string[] args)
    {
        var progam1 = new Program1();
        var program2 = new Program2();

        /*progam1.Run();
        program2.Go();*/

        progam1.Start();
        program2.Start();
        progam1.End();
    }
}
