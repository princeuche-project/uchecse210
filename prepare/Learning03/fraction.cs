using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int Top, int bottom)
    {
        _top = Top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    public double GetDecimalvalue()
    {
        return (double)_top / (double)_bottom;
    }


}



