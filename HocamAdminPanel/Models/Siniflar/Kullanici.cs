using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HocamAdminPanel.Models.Siniflar
{
    public class Kullanici
    {
        [Key]
        
        public int KulId { get; set; }
        public string NickName { get; set; }
        public string sifre { get; set; }
        public string Mail { get; set; }
        public int Yas { get; set; }
        public string HedefSinav { get; set; }
        public int ToplamPuan { get; set; }
        public string egitimDurumu { get; set; }
    }
}