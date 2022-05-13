using DesignPatterns.VisitorPattern.Offers;

namespace DesignPatterns.VisitorPattern.CreditCards;

public class SilverCreditCard : ICreditCard
{
    public string GetName()
    {
        return "Silver";
    }

    public void Accept(IOffer offer)
    {
        offer.VisitSilverCreditCard(this);
    }
}