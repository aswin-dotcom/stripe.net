using Stripe;
//using Stripe.FinancialConnections;
using Stripe.Forwarding;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        StripeConfiguration.ApiKey = "sk_test_51Q24jtI34JL1OXQ341cmz7yzmhVsy1pmsZpz69zsmvtE2ys9peYZsitGxHjAWVpX3thhPf1Xsl4cpXIguKn8g42400eqkTgVn9"; // Replace with your actual Stripe secret key

        var options = new AccountCreateOptions
        {
            Type = "custom",
            Country = "US",
            Email = "email@example.com",
            BusinessType = "individual",
            Individual = new AccountIndividualOptions
            {
                FirstName = "John",
                LastName = "Doe",
            },

            //In Stripe,
            //capabilities are used to define and control what actions a connected account is allowed to perform.When creating or updating a connected account,
            //you need to request specific capabilities depending on your business model and the type of operations you want the account to be able to perform(e.g., making charges, receiving payouts, etc.).

            Capabilities = new AccountCapabilitiesOptions
            {
                Transfers = new AccountCapabilitiesTransfersOptions
                {
                    Requested = true,
                },
                CardPayments = new AccountCapabilitiesCardPaymentsOptions
                {
                    Requested = true,
                },
            },
        };

        var service = new AccountService();
        Console.WriteLine(
        service.Create(options));
    }
   
}
