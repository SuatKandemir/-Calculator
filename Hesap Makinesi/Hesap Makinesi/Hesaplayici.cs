using System;

public class Hesaplayici
{
    public Hesaplayici()
    {

    }

    public double Topla(int num1, int num2)
    {
        return num1 + num2;
    }
    public double Cikar(int num1, int num2)
    {
        return num1 - num2;
    }
    public double Carp(int num1, int num2)
    {
        return num1 * num2;
    }
    public double Bol(int num1, int num2)
    {
        return num1 / num2;
    }

    public bool RakamMi(string sayi)
    {
        foreach (char c in sayi)
        {
            if (!Char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}