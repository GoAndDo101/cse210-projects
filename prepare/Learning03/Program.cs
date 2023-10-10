using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);
        

        float Frac1Dec = fraction1.GetDecimalValue();
        Console.WriteLine(Frac1Dec);

        float Frac2Dec = fraction2.GetDecimalValue();
        Console.WriteLine(Frac2Dec);

        float Frac3Dec = fraction3.GetDecimalValue();
        Console.WriteLine(Frac3Dec);

        string Frac1Str = fraction1.GetFractionString();
        Console.WriteLine(Frac1Str);

    }
}