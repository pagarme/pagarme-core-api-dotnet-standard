﻿using PagarmeCoreApi.Standard;

namespace Example.Subscription
{
    class GetSubscriptionById
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeCoreApiClient(basicAuthUserName, basicAuthPassword);
            string subscrptionId = "sub_05jkdIfGYPfN26mI";

            var response = client.Subscriptions.GetSubscription(subscrptionId);

        }
    }
}
