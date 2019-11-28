namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum EFatura_ProgressTypes
    {
        Undefined = 0,
        OutboxInvoiceWorkerTask = 10,
        QueuedInboxEnvelopeTask = 20,
        CompletedInboxEnvelopeTask = 30,
        CompletedOutboxEnvelopeTask = 40,
        AccountApplicationTask = 50,
        DocumentResponseTask = 60,
        EArsivSendMailTask = 70,
        ApproverTask = 80
    }
}
