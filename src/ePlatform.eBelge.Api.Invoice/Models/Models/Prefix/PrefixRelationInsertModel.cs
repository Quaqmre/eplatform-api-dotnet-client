using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class PrefixRelationInsertModel
    {
        public long RelationId { get; set; }
        public List<PrefixRelationModel> PrefixRelationList { get; set; }
    }
}