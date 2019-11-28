using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_XsltView1")]
    public partial class EfaturaXsltView1
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Type { get; set; }
        public string Data { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IssueDate { get; set; }
    }
}
