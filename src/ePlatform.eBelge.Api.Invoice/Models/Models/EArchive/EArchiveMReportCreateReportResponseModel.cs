using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveMReportCreateReportResponseModel
    {
        public Guid Id { get; set; }
        public DateTime Period { get; set; }
    }
}