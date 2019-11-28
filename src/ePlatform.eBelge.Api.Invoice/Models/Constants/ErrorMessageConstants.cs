namespace ePlatform.eBelge.Api.Models.Models.Constants
{
    public class ErrorMessageConstants
    {
        /// <summary>
        /// InvoiceId alanı boş olamaz!
        /// </summary>
        public const string E_001 = "InvoiceId alanı boş olamaz!";
        /// <summary>
        /// Fatura bulunamadı yada yetkiniz yok!
        /// </summary>
        public const string E_002 = "Fatura bulunamadı yada yetkiniz yok!";
        /// <summary>
        /// Gönderilecek fatura bulunamadı, faturayı doğru eklediğinize emin olunuz!
        /// </summary>
        public const string E_003 = "Gönderilecek fatura bulunamadı, faturayı doğru eklediğinize emin olunuz!";

        /// <summary>
        /// Throw Exception (Fırlatılan hatalar için)
        /// </summary>
        public const string E_004 = "{0} , hata oluştu. Hata: {1} .";

        /// <summary>
        /// Geçerli bir tarih girmelisiz. Hatalı format : {0}
        /// </summary>
        public const string E_005 = "Geçerli bir tarih girmelisiz. Hatalı format : {0}";

        /// <summary>
        /// Kullanıcının sistemde kaydı bulunamadı, EFatura kullanmıyor.
        /// </summary>
        public const string E_006 = "Kullanıcının sistemde kaydı bulunamadı, EFatura kullanmıyor.";

        /// <summary>
        /// Sadece Taslak durumundaki fatura üzerinde değişiklik yapabilirsiniz
        /// </summary>
        public const string E_007 = "Sadece Taslak veya Hatalı durumundaki fatura üzerinde değişiklik yapabilirsiniz";

        /// <summary>
        /// Fatura bilinmeyen bir sebepten dolayı oluşturulamadı.
        /// </summary>
        public const string E_008 = "Fatura bilinmeyen bir sebepten dolayı oluşturulamadı.";

        /// <summary>
        /// Fatura veritabanında güncellenemedi.
        /// </summary>
        public const string E_009 = "Fatura veritabanında güncellenemedi. ";

        /// <summary>
        /// Fatura veritabanına kaydedilemedi
        /// </summary>
        public const string E_010 = "Fatura veritabanına kaydedilemedi";

        /// <summary>
        /// Otomatik fatura numarası oluşturulamadı
        /// </summary>
        public const string E_011 = "Otomatik fatura numarası oluşturulamadı";

        /// <summary>
        /// Müşteri bulunamadı
        /// </summary>
        public const string E_012 = "Müşteri bulunamadı";

        /// <summary>
        /// Sadece Taslak ve Kuyrukta durumunda olan faturayı kayıt edebilirsiniz.
        /// </summary>
        public const string E_013 = "Sadece Taslak ve Kuyrukta durumunda olan faturayı kayıt edebilirsiniz.";

        /// <summary>
        /// {0} datası boş olamaz.
        /// </summary>
        public const string E_014 = "{0} datası boş olamaz.";

        /// <summary>
        /// Fatura dosya sistemimne kaydedilemedi
        /// </summary>
        public const string E_015 = "Fatura dosya sistemimne kaydedilemedi";

        /// <summary>
        /// Bu fatura numaralı kayıt veritabanında mevcuttur.
        /// </summary>
        public const string E_016 = "Bu fatura numaralı kayıt veritabanında mevcuttur.";

        /// <summary>
        /// Fatura numarası olması gereken değerin dışında.
        /// </summary>
        public const string E_017 = "Fatura numarası olması gereken değerin dışında.";

        /// <summary>
        /// Fatura okunurken hata oluştu.
        /// </summary>
        public const string E_018 = "Fatura okunurken hata oluştu.";

        /// <summary>
        /// Fatura önizlemesi için html oluşturulamadı.
        /// </summary>
        public const string E_019 = "Fatura önizlemesi için html oluşturulamadı.";

        /// <summary>
        /// Fatura ZarfId Bulunmadı.
        /// </summary>
        public const string E_020 = "Fatura ZarfId Bulunmadı.";

        /// <summary>
        /// Geçerli bir Guid girmelisiz. Hatalı format : {0}
        /// </summary>
        public const string E_021 = "Geçerli bir Guid girmelisiz. Hatalı format : {0}";

        /// <summary>
        /// Yanıt bulunamadı Bulunmadı.
        /// </summary>
        public const string E_022 = "Yanıt bulunamadı Bulunmadı.";

        /// <summary>
        /// Müşteri Ayarı bulunmadı
        /// </summary>
        public const string E_023 = "Müşteri Ayarı bulunmadı.";

        /// <summary>
        /// Fatura Numarasının sizin tarafından belirlenmesi için ID alanı dolu doğru formatta  olmalıdır. Fatura Numarasi : {0}
        /// </summary>
        public const string E_024 = "Fatura Numarasının sizin tarafından belirlenmesi için ID alanı doğru formatta olmalıdır. Fatura Numarasi : {0}";

        /// <summary>
        /// Daha önce bu  Id ile gönderilen bşr faturanın durumu yeniden göndermeye engeldir. Id:{0}
        /// </summary>
        public const string E_025 = "Daha önce bu Id ile gönderilen bu faturanın durumu, yeniden göndermeye engellidir. Id:{0}, Önceki fatura UUID:{1}";

        /// <summary>
        /// UBLVersionID {0} olmalıdır.
        /// </summary>
        public const string E_026 = "UBLVersionID {0} olmalıdır.";

        /// <summary>
        /// UBLVersionID {0} olmalıdır.
        /// </summary>
        public const string E_027 = "CustomizationID {0} olmalıdır.";

        /// <summary>
        /// {0} Bir adet VKN veya TCKN içermelidir.
        /// </summary>
        public const string E_028 = "{0} Bir adet VKN veya TCKN içermelidir.";

        /// <summary>
        /// {0} - Identifier VKN olarak seçilmiş ise 10 Karakter olmalıdır.
        /// </summary>
        public const string E_029 = "{0} - Identifier VKN olarak seçilmiş ise 10 Karakter olmalıdır.";

        /// <summary>
        /// {0} - Identifier TCKN olarak seçilmiş ise 11 Karakter olmalıdır.
        /// </summary>
        public const string E_030 = "{0} - Identifier TCKN olarak seçilmiş ise 11 Karakter olmalıdır.";

        /// <summary>
        /// Fatura TaxTotal 1 tane TaxTotal içermelidir.
        /// </summary>
        public const string E_031 = "Fatura TaxTotal alanı 1 tane TaxTotal içermelidir.";

        /// <summary>
        /// Önizleme oluşturma(render) hatası.
        /// </summary>
        public const string E_032 = "Önizleme oluşturma(render) hatası";

        /// <summary>
        /// Daha önceden kayıt edilen fatura aynı türden kayıt edilnmelidir.(e-Fatura/e-Arşiv)
        /// </summary>
        public const string E_033 = "Daha önceden kayıt edilen fatura aynı türden kayıt edilmelidir.(e-Fatura/e-Arşiv)";

        /// <summary>
        /// Hatalı AppType e-Fatura için '1' e-Arşiv için '2' olmalıdır.
        /// </summary>
        public const string E_034 = "Hatalı AppType. e-Fatura için '1' e-Arşiv için '2' olmalıdır.";

        /// <summary>
        /// AppType e-Arşiv için '2' olduğunda EArsivInfo dolu olmalıdır.
        /// </summary>
        public const string E_035 = "AppType e-Arşiv için '2' olduğunda EArsivInfo dolu olmalıdır.";

        /// <summary>
        /// e-Arşiv faturası daha Önce iptal edilmiş.
        /// </summary>
        public const string E_036 = "e-Arşiv faturası daha Önce iptal edilmiş.";

        /// <summary>
        /// Prefix türkçe karakter içermemelidir.
        /// </summary>
        public const string E_037 = "Prefix türkçe karakter içermemelidir.";

        /// <summary>
        /// Prefix 3 karakterden oluşmalıdır.
        /// </summary>
        public const string E_038 = "Prefix 3 karakterden oluşmalıdır.";

        /// <summary>
        /// PrefixType 1, 2 ve 3 olabilir.
        /// </summary>
        public const string E_039 = "PrefixType 1, 2 ve 3 olabilir.";

        /// <summary>
        /// e-Arşiv faturası için Fatura Saati zorunludur.
        /// </summary>
        public const string E_040 = "e-Arşiv faturası için Fatura Saati zorunludur.";

        /// <summary>
        /// e-Arşiv faturası bir internet satışına dayanıyorsa UBL içinde AccountingSupplierParty.WebsiteURI alanı dolu olmalıdr.;
        /// </summary>
        public const string E_041 = "e-Arşiv faturası bir internet satışına dayanıyorsa UBL içinde AccountingSupplierParty.WebsiteURI alanı dolu olmalıdr. Portal kullanıyorsanız; Lütfen e-Arşiv sekmesinde, Web Sitesi bilgisini giriniz";

        /// <summary>
        /// PaymentMeans -> PaymentType alanı DIGER(97) olduğunda PaymentMeans -> InstructionNote alanı dolu olmalıdır.
        /// </summary>
        public const string E_042 = "PaymentMeans -> PaymentType alanı DIGER(97) olduğunda PaymentMeans -> InstructionNote alanı dolu olmalıdır.";

        /// <summary>
        /// PaymentMeansCode KREDIKARTI/BANKAKARTI(48),EFT/HAVALE(30),KAPIDAODEME(10),ODEMEARACISI(1) veya DIGER(97) olabilir.
        /// </summary>
        public const string E_043 = "PaymentMeansCode KREDIKARTI/BANKAKARTI(48),EFT/HAVALE(30),KAPIDAODEME(10),ODEMEARACISI(1) veya DIGER(97) olabilir.";

        /// <summary>
        /// e-Arşiv internet Satışlarında Kargo Bilgileri Zorunludur. UBL için Zounlu alanlar Delivery->CarrierParty içinde VKN/TCKN,Name ve Delivery->Despatch->ActualDespatchDate dir.
        /// </summary>
        public const string E_044 = "e-Arşiv internet Satışlarında Kargo Bilgileri Zorunludur. UBL için Zounlu alanlar Delivery->CarrierParty içinde VKN/TCKN,Name ve Delivery->Despatch->ActualDespatchDate dir. Portal kullanıyorsanız; Lütfen e-Arşiv sekmesinden taşıyıcı bilgilerini doldurunuz.";

        /// <summary>
        /// e-Arşiv Faturası için AdditionalDocumentReference eklenmelidir.
        /// </summary>
        public const string E_045 = "e-Arşiv Faturası için AdditionalDocumentReference eklenmelidir.";

        /// <summary>
        /// e-Arşiv Faturası için SendType ID'li AdditionalDocumentReference eklenmelidir ve DocumentType 'KAGIT' veya 'ELEKTRONIK' olmalıdır.
        /// </summary>
        public const string E_046 = "e-Arşiv Faturası için SendType ID'li AdditionalDocumentReference eklenmelidir ve DocumentType'ı 'KAGIT' veya 'ELEKTRONIK' olmalıdır.";

        /// <summary>
        /// e-Arşiv Faturası için IsInternetSale türünde AdditionalDocumentReference eklenmelidir.
        /// </summary>
        public const string E_047 = "e-Arşiv Faturası için IsInternetSale ID'li AdditionalDocumentReference eklenmelidir ve DocumentType'ı 'true' veya 'false' olmalıdır.";

        /// <summary>
        /// e-Arşiv Faturası için SubscriptionType ID'li AdditionalDocumentReference'ın DocumentType'ı UBL-TR Kod Listesinde PartyIdentification için bulunan schemeID değerlerinden birisini alabilir
        /// </summary>
        public const string E_048 = "e-Arşiv Faturası için SubscriptionType ID'li AdditionalDocumentReference'ın DocumentType'ı UBL-TR Kod Listesinde PartyIdentification için bulunan schemeID değerlerinden birisini alabilir.";

        /// <summary>
        /// e-Arşiv Faturasında AdditionalDocumentReference ile SubscriptionType'ı {0} belirtilmiş fakat AccountingCustomerParty içinde {0} schemeID li bilgi gönderilmemiştir.
        /// </summary>
        public const string E_049 = "e-Arşiv Faturasında AdditionalDocumentReference ile SubscriptionType'ı {0} belirtilmiş fakat AccountingCustomerParty içinde {0} schemeID li bilgi gönderilmemiştir.";

        /// <summary>
        /// Fatura için TaxTotal alanı dolu olmalıdır.
        /// </summary>
        public const string E_050 = "Fatura için TaxTotal alanı dolu olmalıdır.";

        /// <summary>
        /// ee-Arşiv faturası bir internet satışına dayanıyorsa UBL içinde PaymentMeans zorunludur ve 1 tane olmalıdır.
        /// </summary>
        public const string E_051 = "e-Arşiv faturası bir internet satışına dayanıyorsa UBL içinde PaymentMeans zorunludur ve 1 tane olmalıdır. Portal kullanıyorsaniz; Lütfen Ödeme sekmesinden seçiniz.";

        /// <summary>
        /// PaymentMeansCode KAPIDAODEME(10) veya DIGER(97) ise PaymentDueDate seçimli, KREDIKARTI/BANKAKARTI(48), EFT/HAVALE(30), ODEMEARACISI(1) ise zorunludur.
        /// </summary>
        public const string E_052 = "PaymentMeansCode KAPIDAODEME(10) veya DIGER(97) ise PaymentDueDate seçimli, KREDIKARTI/BANKAKARTI(48), EFT/HAVALE(30), ODEMEARACISI(1) ise zorunludur.";

        /// <summary>
        /// e-Arşiv faturasını e-posta ile göndermek için geçersiz e-Posta Adresi.
        /// </summary>
        public const string E_053 = "Geçersiz e-Posta Adresi.";

        /// <summary>
        /// İleri bir tarihe fatura kesilemez.
        /// </summary>
        public const string E_054 = "İleri bir tarihe fatura kesilemez.";

        /// <summary>
        /// e-Arşiv Faturası türü "EARSIVFATURA" harici olamaz.
        /// </summary>
        public const string E_055 = "e-Arşiv Faturası türü 'EARSIVFATURA' harici olamaz.";

        /// <summary>
        /// e-Arşiv Faturası için İnternet Satışı bilgisi ilk kayıttan sonra değiştirilemez.
        /// </summary>
        public const string E_056 = "e-Arşiv Faturası için iternet Satışı bilgisi ilk kayıttan sonra değiştirilemez.";

        /// <summary>
        /// Fatura Numarası tarafınızdan belirlendiğinde uzunluğu 16 karakter olmalıdır.
        /// </summary>
        public const string E_057 = "Fatura Numarası tarafınızdan belirlendiğinde uzunluğu 16 karakter olmalıdır.Fatura Numarasi : {0}";

        /// <summary>
        /// Fatura Numarası Yıl bilgisi Fatura tarihi ile aynı yıl olmalıdır.
        /// </summary>
        public const string E_058 = "Fatura numarasının yıl bilgisi fatura tarihi ile aynı yıl olmalıdır.";

        /// <summary>
        /// Fatura vergi bilgisi okunamadı.(UBL -> Invoice.TaxTotal)
        /// </summary>
        public const string E_059 = "Fatura vergi bilgisi okunamadı.(UBL -> Invoice.TaxTotal)";

        /// <summary>
        /// Fatura tevkifat bilgisi okunamadı.(UBL -> Invoice.WithholdingTaxTotal)
        /// </summary>
        public const string E_060 = "Fatura tevkifat bilgisi okunamadı.(UBL -> Invoice.WithholdingTaxTotal)";

        /// <summary>
        /// Daha önce bu LocalReferenceId ile gönderilen bir faturanın durumu yeniden göndermeye engeldir. LocalReferenceId:{0}
        /// </summary>
        public const string E_061 = "Daha önce bu LocalReferenceId ile gönderilen bir faturanın durumu yeniden göndermeye engeldir. LocalReferenceId:{0}, Önceki fatura UUID:{1}";

        /// <summary>
        /// Fatura Numarasının sizin tarafından belirlendiğinde boş olmamalıdır.
        /// </summary>
        public const string E_062 = "Fatura Numarasının sizin tarafından belirlendiğinde boş olmamalıdır.";

        /// <summary>
        /// Sadece başarılı e-Arşiv fatura iptal edilebilir.
        /// </summary>
        public const string E_063 = "Sadece başarılı e-Arşiv fatura iptal edilebilir.";

        /// <summary>
        /// Raporu oluşturulmuş aya e-Arşiv faturası kesemezsiniz.
        /// </summary>
        public const string E_064 = "Raporu oluşturulmuş aya e-Arşiv faturası kesemezsiniz.";

        /// <summary>
        /// Geçersiz e-Posta Adresi. Lütfen Genel sekmesinden e-Posta adresini giriniz.
        /// </summary>
        public const string E_065 = "Geçersiz e-Posta Adresi. Lütfen Genel sekmesinden e-Posta adresini giriniz.";

        /// <summary>
        /// e-Arşiv faturası düzenlendikten 6 ay sonra iptal edilemez.
        /// </summary>
        public const string E_066 = "e-Arşiv faturası düzenlendikten 6 ay sonra iptal edilemez.";

        /// <summary>
        /// Fatura bulunamadı.
        /// </summary>
        public const string E_067 = "Fatura bulunamadı.";

        /// <summary>
        /// Bir yıldan daha önceki bir tarihe fatura kesilemez.
        /// </summary>
        public const string E_068 = "Bir yıldan daha önceki bir tarihe fatura kesilemez.";

        /// <summary>
        /// ÖKC Fiş Bilgilerini eksiksiz olarak doldurmanız gerekmektedir.
        /// </summary>
        public const string E_069 = "ÖKC Fiş Bilgilerini eksiksiz olarak doldurmanız gerekmektedir.";

        public const string E_070 = "UBL içerisindeki UUID alanı ile güncellenmek istenen faturanın Id'si aynı olmalıdır.";

        #region Portal Errors

        /// <summary>
        /// Lütfen e-Arşiv sekmesinde, Web Sitesi bilgisini giriniz
        /// </summary>
        public const string E_Portal_041 = "Lütfen e-Arşiv sekmesinde, web sitesi bilgisini giriniz";

        /// <summary>
        /// PaymentMeans -> PaymentType alanı DIGER(97) olduğunda PaymentMeans -> InstructionNote alanı dolu olmalıdır.
        /// </summary>
        public const string E_Portal_042 = "Ödeme şekli 'Diğer' olduğundan ödeme açıklaması zorunludur.";

        /// <summary>
        /// Ödeme şekli; Kredi kartı/Banka kartı, Eft/Havale, Kapıda Ödeme, Ödeme aracısı veya Diğer olabilir.
        /// </summary>
        public const string E_Portal_043 = "Ödeme şekli; Kredi kartı/Banka kartı, Eft/Havale, Kapıda Ödeme, Ödeme aracısı veya Diğer olabilir.";

        /// <summary>
        /// e-Arşiv internet Satışlarında Kargo Bilgileri Zorunludur. Lütfen e-Arşiv sekmesinden taşıyıcı bilgilerini doldurunuz.
        /// </summary>
        public const string E_Portal_044 = "e-Arşiv internet Satışlarında Kargo Bilgileri Zorunludur. Lütfen e-Arşiv sekmesinden taşıyıcı bilgilerini doldurunuz.";

        /// <summary>
        /// Lütfen Ödeme sekmesinden, ödeme şeklini seçiniz.
        /// </summary>
        public const string E_Portal_051 = "Lütfen Ödeme sekmesinden, ödeme şeklini seçiniz.";

        /// <summary>
        /// Ödeme şekli; Kapıda Ödeme veya Diğer ise Son Ödeme Tarihi seçimli, Kredi Kartı/Banka Kartı, Eft/Havale, Ödeme Aracısı ise Son Ödeme Tarihi zorunludur.
        /// </summary>
        public const string E_Portal_052 = "Ödeme şekli; Kapıda Ödeme veya Diğer ise Son Ödeme Tarihi seçimli, Kredi Kartı/Banka Kartı, Eft/Havale, Ödeme Aracısı ise Son Ödeme Tarihi zorunludur.";

        /// <summary>
        /// e-Arşiv ÖKC Fiş Bilgilerini eksik girdiniz.
        /// </summary>
        public const string E_Portal_053 = "e-Arşiv ÖKC Fiş Bilgilerini eksik girdiniz.";

        #endregion


        /// <summary>
        /// {0} fatura başarıyla alındı, gönderim kuyruğuna eklendi.
        /// </summary>
        public const string S_001 = "{0} - fatura başarıyla alındı, gönderim kuyruğuna eklendi.";

        /// <summary>
        /// Kullanıcı sistemde tanımlı, EFatura gönderilebilir.
        /// </summary>
        public const string S_002 = "Kullanıcı sistemde tanımlı, EFatura gönderilebilir.";

        /// <summary>
        /// Fatura işlemi başarılı.
        /// </summary>
        public const string S_003 = "Fatura işlemi başarılı.";

        /// <summary>
        /// {0} fatura cevabı oluştruldu.
        /// </summary>
        public const string S_005 = "{0} fatura cevabı oluştruldu.";


        /// <summary>
        /// Servis Çağırımı başarılı
        /// </summary>
        public const string S_006 = "Servis Çağırımı başarılı";

        /// <summary>
        /// {0} durum cevabı oluştruldu.
        /// </summary>
        public const string S_007 = "{0} durum cevabı oluştruldu.";
    }

}