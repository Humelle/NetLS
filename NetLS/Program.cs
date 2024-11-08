namespace NetLS;

class Program
{
    public static String IsInside(int x1, int y1, int x2, int y2, int x, int y)
    {
        if (x1 <= x && x <= x2 && y1 <= y && y <= y2)
        {
            return $"Point {x}, {y} is inside the rectangle";
        }

        return $"Point {x}, {y} is outside the rectangle";
    }
    private static bool IsValidSquare(int x1, int y1, int x2, int y2)
    {
        return x1 <= x2 && y1 <= y2;
    }

    static void Main(string[] args)
    {
        int x1, y1, x2, y2, x, y;
        Console.Write("Type x1: ");
        x1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType y1: ");
        y1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType x2: ");
        x2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType y2: ");
        y2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType x: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nType y: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (!IsValidSquare(x1, y1, x2, y2))
        {
            throw new Exception("Invalid square coordinates");
        }
        Console.Write(IsInside(x1, y1, x2, y2, x, y));
        
        
    }

    
}