using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HocamAdminPanel.Models.Siniflar
{
    public class Sorular
    {
        [Key]
        public int SoruId { get; set; }
        public string SoruMetni { get; set; }
        public string aSikki { get; set; }
        public string bSikki { get; set; }
        public string cSikki { get; set; }
        public string dSikki { get; set; }
        public string DogruSik { get; set; }
        public int EkleyenId { get; set; }
        public string DersAdi { get; set; }
        public string BildirimVar { get; set; }
        public string BildirimNedeni { get; set; }
        public string DersKonu { get; set; }



    }
}