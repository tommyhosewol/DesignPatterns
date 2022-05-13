using DesignPatterns.VisitorPattern.Offers;

namespace DesignPatterns.VisitorPattern.CreditCards;

public interface ICreditCard
{
    public string GetName();
    public void Accept(IOffer offer);
}