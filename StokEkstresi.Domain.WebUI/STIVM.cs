using System;

namespace StokEkstresi.Domain.WebUI
{
    public class STIVM:IModel
    {
        public int Id { get; set; }
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
