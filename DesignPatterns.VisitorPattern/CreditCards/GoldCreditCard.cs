using DesignPatterns.VisitorPattern.Offers;

namespace DesignPatterns.VisitorPattern.CreditCards;

public class GoldCreditCard : ICreditCard
{
    public string GetName()
    {
        return "Gold";
    }

    public void Accept(IOffer offer)
    {
        offer.VisitGoldCreditCard(this);
    }
}