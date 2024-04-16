namespace SplitClassLibrary;

public class Split
{
    decimal splitamount(Decimal price, int patrons)
    {
        return price/patrons;
    }
    Dictionary<string, decimal> tipCalculator(Dictionary<string, decimal> individualAmt, float tipPercent)
    {
        Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
        decimal price =0m;
        foreach (var ind in individualAmt)
        {
            decimal price += ind.Value;
        }
        foreach (var ind in individualAmt)
        {
            decimal totalTip = price*tipPercent;
            decimal weigth = ind.Value/price;
            decimal indTipAmt = weight*totalTip;
            tipAmounts.Add(ind.Key, indTipAmt);
        }
        return tipAmounts;
    }
    decimal indTipAmt(decimal price, int patrons, decimal tipPercent)
    {
        return  (price*tipPercent)/patrons;
    }

}
