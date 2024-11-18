namespace NetLS;

class Program
{
   

    static void Main(string[] args)
    {
        int x1, y1, x2, y2, x, y;
        Console.Write("Type xMin: ");
        x1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType yMin: ");
        y1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType xMax: ");
        x2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType yMax: ");
        y2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType x: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType y: ");
        y = Convert.ToInt32(Console.ReadLine());

        SquareUtils pointCheck = new SquareUtils(x1, y1, x2, y2, x, y);
        Console.WriteLine(pointCheck);
        
    }

    
}