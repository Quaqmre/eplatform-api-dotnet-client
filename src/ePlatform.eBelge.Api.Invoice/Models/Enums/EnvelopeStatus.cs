using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum EnvelopeStatus
    {
        [EnumText("Test")]
        Test = 1,
        [EnumText("Hazırlanıyor")]
        Preparing = 100,
        [EnumText("Kuyruğa Eklendi")]
        EnvelopIsQueued = 1000,
        [EnumText("İşleniyor")]
        EnvelopIsProcessing = 1100,
        [EnumText("Zip Dosyası Değil")]
        FileIsNotZip = 1110,
        [EnumText("Id Uzunluğu Geçersiz")]
        InvalidEnvelopIdLength = 1111,
        [EnumText("Arşivden Kopyalanamadı")]
        EnvelopCouldNotCopiedFromArchive = 1120,
        [EnumText("Zip Açılamadı")]
        CouldNotOpenZip = 1130,
        [EnumText("Zip Boş")]
        ZipIsEmpty = 1131,
        [EnumText("Xml Dosyası Değil")]
        FileIsNotXml = 1132,
        [EnumText("Zarf Id ve Xml Dosya Adı Aynı Değil")]
        EnvelopeIdAndXmlNameMustBeSame = 1133,
        [EnumText("Döküman Ayrıştırılamadı")]
        CouldNotParseDocument = 1140,
        [EnumText("Zarf Id Yok")]
        EnvelopeIdNotFound = 1141,
        [EnumText("Zarf Id ve Zip Dosya Adı Aynı Değil")]
        EnvelopeIdAndZipNameMustBeSame = 1142,
        [EnumText("Geçersiz Versiyon")]
        InvalidVersion = 1143,
        [EnumText("Schematron Kontrolü Hatalı")]
        SchematronCheckFailed = 1150,
        [EnumText("Şema Kontrolü Hatalı")]
        XmlSchemaCheckFailed = 1160,
        [EnumText("İmza Sahibi Tck Vkn Alınamadı")]
        CouldNotTakeTcknVknForSigner = 1161,
        [EnumText("İmza Kaydedilemedi")]
        CouldNotSaveSigniture = 1162,
        [EnumText("Gönderilen Zarf Sistemde Daha Önce Kayıtlı Bir Fatura İçeriyor")]
        EnvelopeIdIsAlreadyUsed = 1163,
        [EnumText("İmza Yetkisi Kontrol Edilemedi")]
        CouldNotCheckPermission = 1170,
        [EnumText("Gönderici Birim Yetkisi Yok")]
        DoesNotHaveSenderUnitPermission = 1171,
        [EnumText("Posta Kutusu Yetkisi Yok")]
        DoesNotHavePostBoxPermission = 1172,
        [EnumText("İmza Yetkisi Kontrol Edilemedi")]
        CouldNotCheckSignPermission = 1175,
        [EnumText("İmza Sahibi Yetkisiz")]
        SignerHasNoPermission = 1176,
        [EnumText("Adres Kontrol Edilemedi")]
        CouldNotCheckAddress = 1180,
        [EnumText("Adres Bulunamadı")]
        AddressNotFound = 1181,
        [EnumText("Özel Entegratör Başvurusu Yok")]
        DoesNotHaveEntegratorApplication = 1182,
        [EnumText("Sistem Yanıtı Hazırlanamadı")]
        CouldNotPrepareSystemResponse = 1190,
        [EnumText("Sistem Hatası")]
        SystemError = 1195,
        [EnumText("Zarf Başarıyla İşlendi")]
        EnvelopedProcessSuccessfully = 1200,
        [EnumText("Döküman Bulunan Adrese Gönderilemedi")]
        CouldNotSendDocumentToTheAddress = 1210,
        [EnumText("Döküman Gönderimi Başarısız. Tekrar Gönderme Sonlandı")]
        DocumentSendingFailedWillNotRetry = 1215,
        [EnumText("Hedeften Sistem Yanıtı Gelmedi")]
        TargetDoesNotSendSystemResponse = 1220,
        [EnumText("Hedeften Sistem Yanıtı Başarısız Geldi")]
        TargetSendFailedSystemResponse = 1230,
        [EnumText("Başarıyla Tamamlandı")]
        CompletedSuccessfully = 1300
    }
}
