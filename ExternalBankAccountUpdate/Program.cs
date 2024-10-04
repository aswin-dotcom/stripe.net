using Stripe;
class Program {
    static void Main(string[] args)
    {
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9";
        var options = new AccountExternalAccountUpdateOptions
        {
            Metadata = new Dictionary<string, string> { { "aswin", ".net developer" } },
        };

        var service = new AccountExternalAccountService();

        // Use the connected account ID and the bank account ID
        var externalAccount = service.Update("acct_1Q64wGRFpB2B6SIP", "ba_1Q6826RFpB2B6SIPmIVHKZ0q", options);
        Console.WriteLine(externalAccount);




        //retrive a ba_1Q6826RFpB2B6SIPmIVHKZ0q
        Console.WriteLine(service.Get("acct_1Q64wGRFpB2B6SIP", "ba_1Q6826RFpB2B6SIPmIVHKZ0q"));


        //list all bank account in the connected account 
        var bankaccount = new AccountExternalAccountListOptions { Object = "bank_account" };
        StripeList<IExternalAccount> iExternalAccounts = service.List(
       "acct_1Q64wGRFpB2B6SIP", bankaccount);
        Console.WriteLine(iExternalAccounts);

        //delete a bankaccount
        service.Delete("acct_1Q64wGRFpB2B6SIP", "ba_1Q6826RFpB2B6SIPmIVHKZ0q");




    }
}
