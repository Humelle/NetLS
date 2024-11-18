namespace NetLS;

public class SquareUtils
{
    private double _xMin, _yMin, _xMax, _yMax, _x, _y;

    public SquareUtils(double xMin, double yMin, double xMax, double yMax, double x, double y)
    {
        if (!IsValidSquare(xMin, yMin, xMax, yMax))
        {
            throw new Exception("Invalid square coordinates");
        }

        _xMin = xMin;
        _yMin = yMin;
        _xMax = xMax;
        _yMax = yMax;
        _x = x;
        _y = y;
    }


    public bool IsInside()
    {
        if (_xMin <= _x && _x <= _xMax && _yMin <= _y && _y <= _yMax)
            return true;

        return false;
    }

    private bool IsValidSquare(double x1, double y1, double x2, double y2)
    {
        return x1 <= x2 && y1 <= y2;
    }

    public double xMin
    {
        get => _xMin;
        set
        {
            if (value <= _xMax)
                _xMin = value;
            else
                throw new Exception("Invalid square coordinates");
        }
    }

    public double yMin
    {
        get => _yMin;
        set
        {
            if (value <= _yMax)
                _yMin = value;
            else
                throw new Exception("Invalid square coordinates");
        }
    }

    public double xMax
    {
        get => _xMax;
        set
        {
            if (value >= _xMin)
                _xMax = value;
            else
                throw new Exception("Invalid square coordinates");
        }
    }

    public double yMax
    {
        get => _yMax;
        set
        {
            if (value >= _yMin)
                _yMax = value;
            else
                throw new Exception("Invalid square coordinates");
        }
    }

    public double x
    {
        get => _x;
        set => _x = value;
    }

    public double y
    {
        get => _y;
        set => _y = value;
    }
    
    public override String ToString()
    {
        return $"Square with coordinates {_xMin}, {_yMin}, {_xMax}, {_yMax}\n" +
               $"Point {_x}, {_y} is inside the square: {IsInside()}";
    }
}