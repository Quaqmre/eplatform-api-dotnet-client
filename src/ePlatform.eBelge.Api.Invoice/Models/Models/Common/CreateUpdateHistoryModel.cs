using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class CreateUpdatedHistoryModel
    {
        public CreateUpdatedHistoryModel()
        {
            CreatedDate = DateTime.Now;
            CreatedBy = 0;
            UpdatedDate = DateTime.Now;
            UpdatedBy = 0;
        }

        public DateTime UpdatedDate { get; set; }

        public int UpdatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }
    }
}