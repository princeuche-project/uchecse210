public class Rectangle : Shape
{
    private double _length;
    private double _width;
    private int v1;
    private int v2;

    public Rectangle(string color, int v1, int v2) : base(color)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    private Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}