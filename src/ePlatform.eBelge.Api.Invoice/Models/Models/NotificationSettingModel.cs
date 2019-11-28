using System;
using System.Collections.Generic;

namespace ePlatform.eBelge.Api.Models.Models.Models
{
    public class NotificationSettingModel
    {
        public NotificationSettingModel()
        {
            IdentifierEmailList = new List<IdentifierEmailModel>();
        }
        public bool SendEarsivReport { get; set; }
        public bool SendEfaturaInvoice { get; set; }
        public string Email { get; set; }
        public List<IdentifierEmailModel> IdentifierEmailList { get; set; }
    }

    public partial class IdentifierEmailModel
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string IdentifierEmail { get; set; }
    }
}