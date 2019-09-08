using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StokEkstresi.WebUI.Models.Response
{
    public class Errors
    {
        public string Key { get; set; }
        public string[] ErrorMessages { get; set; }
        public Exception[] Exceptions { get; set; }
    }
}