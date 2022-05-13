using DesignPatterns.VisitorPattern.CreditCards;
using DesignPatterns.VisitorPattern.Offers;

IOffer offer = new BuyCarOffer();
IOffer offer2 = new BuyHotelOffer();

ICreditCard bronze = new BronzeCreditCard();
ICreditCard silver = new SilverCreditCard();
ICreditCard gold = new GoldCreditCard();

// Both types (offer and credit card) are being figured out on runtime
bronze.Accept(offer);
silver.Accept(offer2);
gold.Accept(offer2);

// We can now add unlimited operations to the CreditCards without editing these credit cards.
// When to use? If your operations on the class structure change quite a bit. But now the credit card doesnt have to change at all.