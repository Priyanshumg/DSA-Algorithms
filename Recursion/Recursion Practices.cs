namespace Recursion;

public class Recursion
{
    public int Fibbonaci(int n)
    {
        if (n < 2)
            return n;
        
        return Fibbonaci(n - 1) + Fibbonaci(n - 2);
    }
    
    public void PrintNumbersDesc(int n)
    {
        if (n == 0)
            return;
        Console.WriteLine(n);
        PrintNumbersDesc(n - 1);
    }
    
    public void PrintNumbersAsc(int n)
    {
        if (n == 0)
            return;
        PrintNumbersAsc(n - 1);
        Console.WriteLine(n);
    }
}