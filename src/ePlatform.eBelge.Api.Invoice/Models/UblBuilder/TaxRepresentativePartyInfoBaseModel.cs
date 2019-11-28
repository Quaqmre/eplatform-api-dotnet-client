using System.ComponentModel;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class TaxRepresentativePartyInfoBaseModel
    {
        [DisplayName("Aracı Kurum Vkn")]
        public string RepresentativeVkn { get; set; }

        [DisplayName("Aracı Kurum Etiket")]
        public string RepresentativeAlias { get; set; }

        [DisplayName("İlçe")]
        public string RepresentativeCitySubdivisionName { get; set; }

        [DisplayName("Şehir")]
        public string RepresentativeCity { get; set; }

        [DisplayName("Ülke")]
        public string RepresentativeCountry { get; set; }
    }
}
