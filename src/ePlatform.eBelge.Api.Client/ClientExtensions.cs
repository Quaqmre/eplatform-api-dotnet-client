﻿using ePlatform.Api.Core.Http;
using ePlatform.eBelge.Api.Invoice.Outbox;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using ePlatform.Api.Core.Auth;
using System.Net.Http.Headers;
using ePlatform.eBelge.Api.Invoice.Inbox;
using ePlatform.eBelge.Api.Invoice.EArchive;
using ePlatform.eBelge.Api.Invoice.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ClientExtensions
    {
        private static void AddClients(this IServiceCollection services)
        {
            services.AddHttpClient<AuthClient>(client =>
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            services.AddSingleton<IFlurlClientFactory>(serviceProvider =>
            {
                var auth = serviceProvider.GetService<AuthClient>();
                FlurlHttp.Configure(settings => settings.HttpClientFactory = new PollyHttpClientFactory(auth));
                return new PerBaseUrlFlurlClientFactory();

            });

            services.AddScoped<OutboxInvoiceClient>();
            services.AddScoped<InboxInvoiceClient>();
            services.AddScoped<CommonClient>();
            services.AddScoped<EArchiveClient>();
        }

        private const string ePlatformClientOptionsSectionName = "ePlatformClientOptions";
        public static IServiceCollection AddePlatformClients(this IServiceCollection services, IConfiguration configuration, string sectionName = ePlatformClientOptionsSectionName)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));


            var section = configuration.GetSection(sectionName);
            services.Configure<ClientOptions>(section);

            services.AddClients();

            return services;
        }

        public static IServiceCollection AddePlatformClients(this IServiceCollection services, Action<ClientOptions> clientOptions)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            var options = new ClientOptions();
            var expr = clientOptions ?? delegate { };
            expr(options);

            services.Configure<ClientOptions>(opt =>
            {
                opt.Auth.Username = options.Auth.Username;
                opt.Auth.Password = options.Auth.Password;
                opt.Auth.ClientId = options.Auth.ClientId;
                opt.AuthServiceUrl = options.AuthServiceUrl;
                opt.InvoiceServiceUrl = options.InvoiceServiceUrl;
            });

            services.AddClients();

            return services;
        }
    }
}
