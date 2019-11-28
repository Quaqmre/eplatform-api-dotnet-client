using System.ComponentModel;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class InvoiceLineDeliveryInfoBaseModel
    {
        [DisplayName("Teslim Şartı")]
        public string DeliveryTermsId { get; set; }

        [DisplayName("Kabın cinsi ve nevi")]
        public string PackagingTypeCode { get; set; }

        [DisplayName("Kabın numarası")]
        public string PackagingId { get; set; }

        [DisplayName("Kabın adedi")]
        public string Quantity { get; set; }

        [DisplayName("Gönderilme şekli")]
        public string TransportModeCode { get; set; }

        [DisplayName("GTİP No")]
        public string RequiredCustomsId { get; set; }


        [DisplayName("Teslim Ülkesi")]
        public string DeliveryCountry { get; set; }

        [DisplayName("Teslim Şehri")]
        public string DeliveryCity { get; set; }

        [DisplayName("Teslim İlçesi")]
        public string DeliveryDistrict { get; set; }

        [DisplayName("Teslim Sokak/Cadde Adı")]
        public string DeliveryStreetName { get; set; }

        [DisplayName("Teslim Bina Numarası")]
        public string DeliveryBuildingNumber { get; set; }

        [DisplayName("Teslim Bina Adı")]
        public string DeliveryBuildingName { get; set; }

        [DisplayName("Teslim postaKodu")]
        public string DeliveryPostalZone { get; set; }


        //Zorunlu olmayan alanlar
        //TransPortMeans
        [DisplayName("Gönderilme şekli havayolu detayı")]
        public string AirTransportId { get; set; }

        [DisplayName("Gönderilme şekli karayolu detayı")]
        public string RoadTransportId { get; set; }

        [DisplayName("Gönderilme şekli demiryolu detayı")]
        public string RailTransportId { get; set; }

        [DisplayName("Gönderilme şekli denizyolu detayı")]
        public string MaritimeTransportId { get; set; }
    }
}