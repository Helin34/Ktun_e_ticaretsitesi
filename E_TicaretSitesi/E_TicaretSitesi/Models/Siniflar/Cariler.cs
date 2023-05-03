using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_TicaretSitesi.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string  CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]

        public string  CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariMail { get; set; }
        public SatisHareket SatisHareket { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}