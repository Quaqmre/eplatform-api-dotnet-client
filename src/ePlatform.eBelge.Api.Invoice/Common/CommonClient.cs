using ePlatform.Api.Core.Extensions;
using ePlatform.Api.Core.Http;
using ePlatform.Api.Core.QueryBuilder;
using ePlatform.eBelge.Api.Invoice.Models;
using ePlatform.eBelge.Api.Invoice.Models.Enums;
using ePlatform.eBelge.Api.Models.Models;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ePlatform.eBelge.Api.Invoice.Common
{
    public class CommonClient
    {
        private readonly ClientOptions clientOptions;
        private readonly IFlurlClient flurlClient;
        public CommonClient(IOptions<ClientOptions> clientOptions, IFlurlClientFactory flurlClientFac)
        {
            this.clientOptions = clientOptions.Value;
            flurlClient = flurlClientFac.Get(this.clientOptions.InvoiceServiceUrl).SetDefaultSettings();
        }

        /// <summary>
        /// Http Code 200 means is user else is not user  eFatura=1,eIrsaliye=3
        /// </summary>
        public async Task<bool> IsUser(string identifier, int appType)
        {
            var response = await flurlClient.Request($"/v1/gibuser/isuser")
                .SetQueryParam("identifier", identifier)
                .SetQueryParam("appType", appType)
                .GetAsync();
            return response.IsSuccessStatusCode;
        }

        public async Task<GibUserWithAliasModel> GetUser(string identifier)
        {
            return await flurlClient.Request($"/v1/gibuser/getuser")
                .SetQueryParam("identifier", identifier)
                .GetJsonAsync<GibUserWithAliasModel>();
        }

        /// <summary>
        /// QueryFilter model:GibUserAliasModel
        /// </summary>
        public async Task<PagedList<GibUserAliasModel>> GetUserAliasList(PagingModel model)
        {
            var list = await flurlClient.Request($"/v1/gibuser/receiverboxaliaslist")
                .SetQueryParams(model)
                .GetJsonAsync<PagedList<GibUserAliasModel>>();
            return list;
        }

        public async Task<List<CurrencyModel>> CurrencyCodeList()
        {
            return await flurlClient.Request($"/v1/staticlist/currency")
                .GetJsonAsync<List<CurrencyModel>>();
        }

        public async Task<List<UnitCodeModel>> UnitCodeList()
        {
            return await flurlClient.Request($"/v1/staticlist/unit")
                .GetJsonAsync<List<UnitCodeModel>>();
        }

        public async Task<List<TaxExemptionReasonModel>> TaxExemptionReasonList()
        {
            return await flurlClient.Request($"/v1/staticlist/taxexemptionreason")
                .GetJsonAsync<List<TaxExemptionReasonModel>>();
        }

        public async Task<List<WithHoldingCodeModel>> WithHoldingList()
        {
            return await flurlClient.Request($"/v1/staticlist/withholding")
                .GetJsonAsync<List<WithHoldingCodeModel>>();
        }

        public async Task<List<TaxTypeCodeModel>> TaxTypeCodeList()
        {
            return await flurlClient.Request($"/v1/staticlist/taxtypecode")
                .GetJsonAsync<List<TaxTypeCodeModel>>();
        }

        public async Task<List<TaxOfficeModel>> TaxOfficeList()
        {
            return await flurlClient.Request($"/v1/staticlist/taxoffice")
                .GetJsonAsync<List<TaxOfficeModel>>();
        }

        public async Task<List<CountryModel>> CountrList()
        {
            return await flurlClient.Request($"/v1/staticlist/country")
                .GetJsonAsync<List<CountryModel>>();
        }
    }
}
