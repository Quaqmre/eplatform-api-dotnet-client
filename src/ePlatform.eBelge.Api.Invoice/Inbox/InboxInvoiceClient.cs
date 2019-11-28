using ePlatform.Api.Core.Http;
using ePlatform.Api.Core.QueryBuilder;
using ePlatform.eBelge.Api.Models.Models;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ePlatform.eBelge.Api.Invoice.Inbox
{
    public class InboxInvoiceClient
    {
        private readonly ClientOptions clientOptions;
        private readonly IFlurlClient flurlClient;

        public InboxInvoiceClient(IOptions<ClientOptions> clientOptions, IFlurlClientFactory flurlClientFac)
        {
            this.clientOptions = clientOptions.Value;
            flurlClient = flurlClientFac.Get(this.clientOptions.InvoiceServiceUrl).SetDefaultSettings();
        }

        public async Task<InboxInvoiceGetModel> Get(Guid id)
        {
            return await flurlClient.Request($"/v1/inboxinvoice/{id}")
                .GetJsonAsync<InboxInvoiceGetModel>();
        }

        public async Task<UblBuilderModel> GetInvoice(Guid id)
        {
            return await flurlClient.Request($"/v1/inboxinvoice/getinvoice")
                .SetQueryParam("guid", id)
                .GetJsonAsync<UblBuilderModel>();
        }

        public async Task<PagedList<InboxInvoiceGetModel>> GetList(PagingModel model)
        {
            return await flurlClient.Request($"/v1/inboxinvoice/list")
                .SetQueryParams(model)
                .GetJsonAsync<PagedList<InboxInvoiceGetModel>>();
        }

        public async Task<InboxInvoiceModel> GetWithEnvelopes(Guid id)
        {
            return await flurlClient.Request($"/v1/inboxinvoice/getwithenvelopes/{id}")
                .GetJsonAsync<InboxInvoiceModel>();
        }

        public async Task<List<InboxInvoiceModel>> GetInboxInvoicesByEnvelopeId(Guid id)
        {
            return await flurlClient.Request($"/v1/inboxinvoice/getinvoicesbyenvelopeid/{id}")
                .GetJsonAsync<List<InboxInvoiceModel>>();
        }

        public async Task<bool> DeleteInboxInvoiceWithTaxes(Guid id)
        {
            var response = await flurlClient.Request($"/v1/inboxinvoice/deletewithtaxes/{id}")
                .DeleteAsync();
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> SendOrRemoveArchive(UpdateInvoiceModel model)
        {
            var response = await flurlClient.Request($"/v1/inboxinvoice/sendorremovearchivelist")
                .PutJsonAsync(model);
            return response.IsSuccessStatusCode;
        }

        public async Task<string> GetPreviewHtml(Guid id, bool isStandartXslt)
        {
            var reponse = await flurlClient.Request($"/v2/inboxinvoice/{id}/html")
                .SetQueryParam("isStandartXslt", isStandartXslt)
                .GetAsync();
            return await reponse.Content.ReadAsStringAsync();
        }

        public async Task<byte[]> GetPdf(Guid id, bool isStandartXslt)
        {
            var reponse = await flurlClient.Request($"/v2/inboxinvoice/{id}/pdf")
                .SetQueryParam("isStandartXslt", isStandartXslt)
                .GetAsync();
            return await reponse.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> GetPdfList(InvoicePdfModel model)
        {
            var reponse = await flurlClient.Request($"/v1/inboxinvoice/pdflist")
            .PostJsonAsync(model);
            return await reponse.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> GetUbl(Guid id)
        {
            var reponse = await flurlClient.Request($"/v2/inboxinvoice/{id}/ubl")
                .GetAsync();
            return await reponse.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> GetUblList(Guid[] ids)
        {
            var reponse = await flurlClient.Request($"/v1/inboxinvoice/ubllist")
            .PostJsonAsync(ids);
            return await reponse.Content.ReadAsByteArrayAsync();
        }

        public async Task<ApproveRejectInvoiceModel> GetInvoiceResponse(Guid id)
        {
            return await flurlClient.Request($"/v1/invoiceresponse/getbyinvoiceid/{id}")
                .GetJsonAsync<ApproveRejectInvoiceModel>();
        }

        public async Task<DocumentResponseModel> ApproveReject(ApproveRejectInvoiceModel model)
        {
            var reponseModel = await flurlClient.Request($"/v1/invoiceresponse")
                .PostJsonAsync(model)
                .ReceiveJson<DocumentResponseModel>();
            return reponseModel;
        }
    }
}
