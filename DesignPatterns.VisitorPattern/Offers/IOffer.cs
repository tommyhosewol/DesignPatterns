using DesignPatterns.VisitorPattern.CreditCards;

namespace DesignPatterns.VisitorPattern.Offers;

public interface IOffer
{
    public void VisitBronzeCreditCard(BronzeCreditCard card);
    public void VisitSilverCreditCard(SilverCreditCard card);
    public void VisitGoldCreditCard(GoldCreditCard card);
}