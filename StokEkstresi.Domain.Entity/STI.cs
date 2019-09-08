using StokEkstresi.Domain.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokEkstresi.Domain.Entity
{
  public class STI:EntityBase
    {
        public int IslemTur { get; set; }
        public int EvrakNo { get; set; }
        public int Tarih { get; set; }
        public string MalKodu { get; set; }
        public int Miktar { get; set; }
        public int Fiyat { get; set; }
        public int Tutar { get; set; }
        public int Birim { get; set; }
    }
}
