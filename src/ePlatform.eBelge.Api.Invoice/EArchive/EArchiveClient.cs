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

namespace ePlatform.eBelge.Api.Invoice.EArchive
{
    public class EArchiveClient
    {
        private readonly ClientOptions clientOptions;
        private readonly IFlurlClient flurlClient;
        public UblBuilderModel NewOutboxInvoceModel()
        {
            return new UblBuilderModel() { RecordType = (int)RecordType.Invoice, };
        }
        public InvoiceLineBaseModel<InvoiceLineTaxBaseModel> NewInvoceLineModel()
        {

            return new InvoiceLineBaseModel<InvoiceLineTaxBaseModel>();
        }
        public EArchiveClient(IOptions<ClientOptions> clientOptions, IFlurlClientFactory flurlClientFac)
        {
            this.clientOptions = clientOptions.Value;
            flurlClient = flurlClientFac.Get(this.clientOptions.InvoiceServiceUrl).SetDefaultSettings();
        }
        /// <summary>
        /// Get One Outbox Invoice with Guid Id
        /// </summary>
        public async Task<OutboxInvoiceGetModel> Get(Guid id)
        {
            return await flurlClient.Request($"/v1/earchive/{id}")
                .GetJsonAsync<OutboxInvoiceGetModel>();
        }
        /// <summary>
        /// Get All Outbox Invoice or Filtered List
        /// </summary>
        public async Task<PagedList<OutboxInvoiceGetModel>> GetList(PagingModel model)
        {
            var list = await flurlClient.Request($"/v1/earchive/list")
                .SetQueryParams(model)
                .GetJsonAsync<PagedList<OutboxInvoiceGetModel>>();
            return list;
        }

        /// <summary>
        /// Email Status:
        /// Created=0,Queued=10,Send=20,Failed=30,SendStopped=40
        /// </summary>
        public async Task<List<EarsivInvoiceMailModel>> GetMailDetail(string id)
        {
            return await flurlClient.Request($"/v1/earchive/getmaildetail")
                .SetQueryParam("id", id.ToString())
                .GetJsonAsync<List<EarsivInvoiceMailModel>>();
        }
        public async Task<bool> CancelInvoice(Guid[] ids)
        {
            var response = await flurlClient.Request($"/v1/earchive/cancelinvoice")
                .PutJsonAsync(ids);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> ReTryInvoiceMail(Guid id)
        {
            var response = await flurlClient.Request($"/v1/earchive/retryinvoicemail/{id}")
                .GetAsync();
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RetryInvoiceWithDifferentMail(Guid id, string mail)
        {
            var response = await flurlClient.Request($"/v1/earchive/retryinvoicemail/{id}/{mail}")
                .GetAsync();
            return response.IsSuccessStatusCode;
        }
    }
}
