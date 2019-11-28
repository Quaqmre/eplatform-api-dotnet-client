using System;
using ePlatform.eBelge.Api.Models.Models.Enum;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public int? CustomerType { get; set; }
        public bool IsActive { get; set; }

        public CustomerType CustomerTypeEnum
        {
            get
            {
                return (CustomerType)this.CustomerType;
            }
            set
            {
                this.CustomerType = Convert.ToInt32(value);
            }
        }
    }
}