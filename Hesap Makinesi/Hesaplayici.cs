using System;

public class Hesaplayici
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

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
}