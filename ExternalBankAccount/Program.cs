using Stripe;

class Program {
    static void Main(string[] args)
    {
        
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9";

        var options = new AccountExternalAccountCreateOptions
        {
            ExternalAccount = new AccountExternalAccountBankAccountOptions
            {
                AccountNumber = "000123456789",  
                RoutingNumber = "110000000",   
                Country = "US",
                Currency = "usd",
                AccountHolderName = "ASWIN SAMUVEL E",
                AccountHolderType = "individual"
            }   
        };

        var service = new AccountExternalAccountService();
        var externalAccount = service.Create("acct_1032D82eZvKYlo2C", options);  // Connected account ID

        Console.WriteLine(externalAccount.Id);

    }
} 
