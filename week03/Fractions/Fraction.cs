using System;
using System.Collections.Generic;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        GetFractionString();
        GetDecimalValue();
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
        GetFractionString();
        GetDecimalValue();
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        GetFractionString();
        GetDecimalValue();
    }


    /*Getters and Setters*/

    public int GetTop()
    {
        return _top;
        
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    /**/
    
    public string GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        Console.WriteLine((double)_top / _bottom);
        return (double)_top / _bottom;
    }
}