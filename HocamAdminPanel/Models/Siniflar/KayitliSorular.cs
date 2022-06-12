using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HocamAdminPanel.Models.Siniflar
{
    public class KayitliSorular
    {
        [Key]
        public int KayitId { get; set; }
        public int SoruId { get; set; }
        public int EkleyenId { get; set; }
        public int KaydedenId { get; set; }
    }
}