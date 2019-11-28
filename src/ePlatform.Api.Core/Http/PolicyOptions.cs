using System;

namespace ePlatform.Api.Core.Http
{
    public class PolicyOptions
    {
        public CircuitBreakerPolicyOptions HttpCircuitBreaker { get; set; }
        public RetryPolicyOptions HttpRetry { get; set; }

        public class CircuitBreakerPolicyOptions
        {
            public TimeSpan DurationOfBreak { get; set; } = TimeSpan.FromSeconds(30);
            public int ExceptionsAllowedBeforeBreaking { get; set; } = 12;
        }

        public class RetryPolicyOptions
        {
            public int Count { get; set; } = 3;

            /// <summary>
            /// Her bir retry için beklenecek süre hesaplanırken exponansiye artış hesabı
            /// 1.async retry => pow üzeri 1 kadar (pow =2 için 2^1=2 saniye bekle)
            /// 2.async retry => pow üzeri 2 kadar (pow =2 için 2^2=4 saniye bekle)
            /// 3.async retry => pow üzeri 2 kadar (pow =2 için 2^3=8 saniye bekle)
            /// </summary>
            /// <value></value>
            public int Pow { get; set; } = 2;
        }
    }
}
