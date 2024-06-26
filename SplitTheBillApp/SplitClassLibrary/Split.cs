﻿namespace SplitClassLibrary;

public class Split
{
    public static decimal splitamount(Decimal price, int patrons)
    {
        if (patrons <= 0)
        {
            throw new DivideByZeroException("Number of patrons cannot be zero or less.");
        }
        return price / patrons;
    }
    public static Dictionary<string, decimal> tipCalculator(Dictionary<string, decimal> individualAmt, float tipPercent)
    {
        Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();

        if (individualAmt == null || individualAmt.Count == 0 || tipPercent <= 0)
        {
            return tipAmounts; // Return an empty dictionary if input is invalid
        }

        decimal totalPrice = 0m;

        // Calculate the total price of all individual amounts
        foreach (var ind in individualAmt)
        {
            totalPrice += ind.Value;
        }

        // Calculate tip amount for each individual based on their weighted contribution
        foreach (var ind in individualAmt)
        {
            decimal totalTip = totalPrice * (decimal)(tipPercent / 100); // Convert tip percentage to decimal
            decimal weight = ind.Value / totalPrice;
            decimal indTipAmt = weight * totalTip;
            tipAmounts.Add(ind.Key, indTipAmt);
        }

        return tipAmounts;
    }
    public static decimal indTipAmt(decimal price, int patrons, decimal tipPercentage)
    {
        if (tipPercentage < 0)
        {
            throw new ArgumentException("Tip percentage cannot be negative.", nameof(tipPercentage));
        }

        if (price <= 0 || patrons <= 0)
        {
            return 0m;
        }

        decimal tipAmount = price * (tipPercentage / 100);
        return tipAmount / patrons;

    }

}
