using DesignPatterns.VisitorPattern.CreditCards;

namespace DesignPatterns.VisitorPattern.Offers;

public class BuyCarOffer : IOffer
{
    public void VisitBronzeCreditCard(BronzeCreditCard card)
    {
        Console.WriteLine("We are computing the cashback for a bronze card buying a car.");
    }

    public void VisitSilverCreditCard(SilverCreditCard card)
    {
        Console.WriteLine("We are computing the cashback for a silver card buying a car.");
    }

    public void VisitGoldCreditCard(GoldCreditCard card)
    {
        Console.WriteLine("We are computing the cashback for a gold card buying a car.");
    }
}