using Stripe;

class main
{
    static void Main (String[] args)
    {
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9";

        //add additional details in the metadate  of the particular connected account 

        var options = new AccountUpdateOptions
        {
            Metadata = new Dictionary<string, string> { { "aswin", ".net developer" } },
        };
        var service = new AccountService();
        Console.WriteLine(
        service.Update("acct_1Q63PGICEEM4gDIc", options));

        //to retrive  the connected account object
        Console.WriteLine(service.Get("acct_1Q63PGICEEM4gDIc"));


        // list all connected account to your platform
        var list = new AccountListOptions { Limit = 20 };
        StripeList<Account> accounts = service.List(list);
        //returns array of objects
        Console.WriteLine(accounts);


        //delete the connectedaccount
        Console.WriteLine(service.Delete("acct_1Q63KtIA7ejPFQGl"));


        //reject the account   "disabled_reason": "rejected.fraud", just disable the account
        var reject = new AccountRejectOptions { Reason = "fraud" };
        Console.WriteLine(service.Reject("acct_1Q258lRDPLnwLFh1", reject));
        


    }
}