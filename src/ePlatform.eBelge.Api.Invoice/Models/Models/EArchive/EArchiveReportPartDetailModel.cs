using System.Collections.Generic;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveReportPartDetailModel
    {
        public long Id { get; set; }
        public string faturaNo { get; set; }
        public string gonderimSekli { get; set; }
        public string dosyaAdi { get; set; }
        public string ozetDeger { get; set; }
        public string duzenlenmeTarihi { get; set; }
        public string duzenlenmeZamani { get; set; }
        public string toplamTutar { get; set; }
        public string odenecekTutar { get; set; }
        public string paraBirimi { get; set; }
        public string vergilerToplami { get; set; }
        public string vkn { get; set; }
        public string unvan { get; set; }
        public string tckn { get; set; }
        public string adiSoyadi { get; set; }
        public string tesisatNumarasi { get; set; }
        public string webAdresi { get; set; }
        public string odemeSekli { get; set; }
        public string odemeAracisiAdi { get; set; }
        public string odemeTarihi { get; set; }
        public string gonderimTarihi { get; set; }
        public string tuzelKisi_vkn { get; set; }
        public string tuzelKisi_unvan { get; set; }
        public string gercekKisi_tckn { get; set; }
        public string gercekKisi_adiSoyadi { get; set; }
        public string iptal { get; set; }
        public List<ReportPartDetailTaxModel> vergi { get; set; }
    }
}