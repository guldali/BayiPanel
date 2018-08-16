using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bootstrap.Model {
    [Table("BayiKart")]
    public class BayiKart {

        public long Id { get; set; }

        [DisplayName("Ünvan")]
        public String Unvan { get; set; }

        [DisplayName("Bayi Api IP Adresi")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bayinin IP bilgisini girmelisiniz!")]
        [RegularExpression(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b",ErrorMessage ="IP adresi doğru değil!")]
        public string BayiHost { get; set; }

        [DisplayName("Opet Veri Aktarım")]
        public bool BayiOpetAktarimi { get; set; }

        [DisplayName("Bayi Api Port")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bayinin Port bilgisini girmelisiniz!")]
        public int BayiPort { get; set; }

        [DisplayName("Bayi Api Virtual Directory")]
        public string BayiApiVirtualDirectory { get; set; }

        [DisplayName("Bayi Api Versiyon")]
        public string BayiApiVersion { get; set; }

        [DisplayName("Opet Api Protokol")]
        public string OpetApiProtocol { get; set; }

        [DisplayName("Opet Api Host")]
        public string OpetApiHost { get; set; }

        [DisplayName("Opet Api Port")]
        public int OpetApiPort { get; set; }

        [DisplayName("Opet Api Virtual Directory")]
        public string OpetApiVirtualDirectory { get; set; }

        [DisplayName("Opet Api Versiyon")]
        public string OpetApiVersion { get; set; }

        [DisplayName("Crone İfadesi")]
        public string CronExpression { get; set; }

        [DisplayName("Api Id")]
        public string ApiId { get; set; }

        [DisplayName("Api Key")]
        public string ApiKey { get; set; }

        [DisplayName("Toplu Gönderim Sınırı")]
        public int BulkRecordLimit { get; set; }

        [DisplayName("SQL Server Zaman Aşımı Süresi")]
        public int ApiSqlServerTimeout { get; set; }

        [DisplayName("Eşleştirilecek Tablolar")]
        public string SyncTables { get; set; }

        [DisplayName("Şifreleme Kullan")]
        public bool UseToken { get; set; }

        [DisplayName("Günlük Seviyesi")]
        public string LogLevel { get; set; }

        [DisplayName("Otomatik Takvimle")]
        public bool UseAutoScheduling { get; set; }

        [DisplayName("Test Eşleştirmesi")]
        public bool TestSync { get; set; }
    }
}