using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class PrefixRelationModel
    {
        public int Id { get; set; }
        public int PrefixId { get; set; }
        public long RelationId { get; set; }
        public int RelationType { get; set; }
        public bool IsDefaultRelation { get; set; }
        public int Type { get; set; }
        public string Prefix { get; set; }
        public bool IsDefault { get; set; }
    }
}