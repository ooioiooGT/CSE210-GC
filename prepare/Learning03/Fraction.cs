using System;

public class Fraction
{
    private int _gctop;
    private int _gcbottom;
    public Fraction()
    {
        _gctop = 1 ;
        _gcbottom = 1; 
    }
    public Fraction(int gcWholeNumber)
    {
        _gctop = gcWholeNumber;
        _gcbottom = 1; 
    }
    public Fraction(int gcTop, int gcBottom)
    {
        _gctop = gcTop;
        _gcbottom = gcBottom;
    }
    public string GcGetFractionString()
    {
        string gcString = $"{_gctop}/{_gcbottom}";
        return gcString;
    }
    public double GcGetDecimalValue()
    {
        return (double)_gctop/ (double)_gcbottom;
    }


}