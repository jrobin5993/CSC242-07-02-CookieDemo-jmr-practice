using System;

public class CookieOrder
{
    public int OrderNumber { get; set; }
    public string RecipientName { get; set; }
    public string CookieType { get; set; }
    private int dozens;
    private decimal price;

    public int Dozens
    {
        get { return dozens; }
        set
        {
            dozens = value;
            CalculatePrice();
        }
    }
    public decimal Price
    {
        get { return price; }
    }

    protected virtual void CalculatePrice()
    {
        if (dozens <= 2)
            price = dozens * 15m;
        else
            price = (2 * 15m) + ((dozens - 2) * 13m);
    }
}

