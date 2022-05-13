using DesignPatterns.VisitorPattern.Offers;

namespace DesignPatterns.VisitorPattern.CreditCards;

public class BronzeCreditCard : ICreditCard
{
    public string GetName()
    {
        return "Bronze";
    }

    public void Accept(IOffer offer)
    {
        offer.VisitBronzeCreditCard(this);
    }
}