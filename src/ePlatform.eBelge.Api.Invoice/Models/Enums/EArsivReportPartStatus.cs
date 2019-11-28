namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum EArsivReportPartStatus
    {
        Created = 1,
        Generated = 2,
        Signed = 3,
        PassedSchemaValidation = 4,
        /// <summary>
        /// Gönderilmeyi Bekliyor
        /// </summary>
        ServiceWaitingSend = 10,
        /// <summary>
        /// Gönderilmiş
        /// </summary>
        ServiceSent = 11,
        /// <summary>
        /// 
        /// </summary>
        ServiceErrorSend = 12,
        /// <summary>
        /// Arşivlendi.
        /// </summary>
        Archived = 13,
        /// <summary>
        /// 
        /// </summary>
        ServiceErrorArchived = 14,
        Error = 20,
    }
}