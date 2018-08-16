namespace Bootstrap.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Durumlar")]
    public partial class Durumlar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonIgnore]
        public int id { get; set; }
        [JsonProperty("y")]
        public int Deger { get; set; }

        [StringLength(10)]
        [JsonProperty("label")]
        public string Durum { get; set; }

        
        public int Tip { get; set; }

    }
}
