using System;
using ePlatform.Api.Core.QueryBuilder;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveMReportListModel
    {
        public DateTime Period { get; set; }
        public DateTime CreatedDate { get; set; }
        public PagedList<EArchiveMReportModel> MReportList { get; set; }
    }
}