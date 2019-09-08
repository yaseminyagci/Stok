using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokEkstresi.Domain.WebUI.Filter
{
   public class STKFilter
    {[DisplayName(  "Stk Mal Kodu")]
        public string MalKodu { get; set; }
        [DisplayName("STK Mal Adı")]
        public string MalAdı { get; set; }
        [DisplayName("Giriş Tarih")]
        public int GirisTarih { get; set; }
        [DisplayName("ÇıkışTarih")]
        public int CikisTarih { get; set; }
    }
}
