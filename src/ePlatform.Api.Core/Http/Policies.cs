using ePlatform.Api.Core.Auth;
using Polly;
using Polly.Retry;
using Polly.Wrap;
using System;
using System.Net.Http;

namespace ePlatform.Api.Core.Http
{
    public static class Policies
    {
        private static AsyncRetryPolicy<HttpResponseMessage> TokenRefreshPolicy
        {
            get
            {
                return Policy
                    .HandleResult<HttpResponseMessage>(r => r.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    .WaitAndRetryAsync(
                        retryCount: 2,
                        sleepDurationProvider: retryAttempt => TimeSpan.FromMilliseconds(2 * Math.Pow(2, retryAttempt)),
                        onRetryAsync: async (exception, timeSpan, currentRetry, context) =>
                        {
                            if (context.TryGetValue("authClient", out var client) && client is AuthClient authClient)
                            {
                                await authClient.RefreshToken();
                            }

                            var a = exception;
                        });
            }
        }
        private static AsyncPolicy<HttpResponseMessage> deneme
        {
            get
            {
                return Policy
                    .HandleResult<HttpResponseMessage>(r => r.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                    .WaitAndRetryAsync(1, (x) => new TimeSpan(100));
            }
        }

        public static AsyncPolicyWrap<HttpResponseMessage> PolicyStrategy => Policy.WrapAsync(TokenRefreshPolicy, deneme);
    }
}
