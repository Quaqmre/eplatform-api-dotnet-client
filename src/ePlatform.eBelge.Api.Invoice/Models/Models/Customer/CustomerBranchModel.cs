using System;

namespace ePlatform.eBelge.Api.Models.Models.Models
{
    public class CustomerBranchModel
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public Guid UniqueId { get; set; }
        public string BranchName { get; set; }
        public string Name { get; set; }
        public string DealerCode { get; set; }
    }
}