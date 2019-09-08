using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokEkstresi.Domain.WebUI
{
  public  class STKVM:IModel
    {
        public int Id { get; set; }
        public string MalKodu { get; set; }
        public string MalAdı { get; set; }
    }
}
