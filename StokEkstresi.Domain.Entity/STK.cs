using StokEkstresi.Domain.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokEkstresi.Domain.Entity
{
  public  class STK:EntityBase
    {
        public string MalKodu { get; set; }
        public string MalAdı { get; set; }
    }
}
