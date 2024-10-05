using Stripe;

class Program {
    static void Main(string[] args)
    {
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9";


        var options = new AccountExternalAccountCreateOptions
        {
            ExternalAccount = "tok_visa_debit",
        };
        var service = new AccountExternalAccountService();
        service.Create("acct_1Q64wGRFpB2B6SIP", options);
    }
}