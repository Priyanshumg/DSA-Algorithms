namespace Recursion;

class Program
{
       
    static void Main(string[] args)
    {
        Recursion req = new Recursion();
        // req.PrintNumbersAsc(5);
        Console.WriteLine(req.Fibbonaci(1000));
    }
}