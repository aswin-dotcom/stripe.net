using Stripe;

class main {
    static void Main(String[] args) {
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9";
        //They help new connected accounts complete the registration process.

        var options = new AccountLinkCreateOptions
        {
            Account = "acct_1Q64wGRFpB2B6SIP",
            RefreshUrl = "https://example.com/reauth",
            ReturnUrl = "https://example.com/return",
            Type = "account_onboarding",
        };
        var service = new AccountLinkService();
        Console.WriteLine(
        service.Create(options));





    }
}
