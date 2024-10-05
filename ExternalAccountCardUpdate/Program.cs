using Stripe;

class Program
{
    static void Main(string[] args)
    {
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9";
        var options = new AccountExternalAccountUpdateOptions
        {
            Metadata = new Dictionary<string, string> { { "card ", "ind" } },
        };
        var service = new AccountExternalAccountService();
        Console.WriteLine(
        service.Update("acct_1Q64wGRFpB2B6SIP", "card_1Q69R3RFpB2B6SIPlUT51bpk", options));


        //to retrive the card details
        Console.WriteLine(
        service.Get("acct_1Q64wGRFpB2B6SIP", "card_1Q69R3RFpB2B6SIPlUT51bpk"));


        //to list all the cards in the connected accounts
        var option = new AccountExternalAccountListOptions { Object = "card" };
        StripeList<IExternalAccount> iExternalAccounts = service.List("acct_1Q64wGRFpB2B6SIP", option);
        Console.WriteLine(iExternalAccounts);



        //Delete the card

        service.Delete("acct_1Q64wGRFpB2B6SIP", "card_1Q69R3RFpB2B6SIPlUT51bpk");
    }
}