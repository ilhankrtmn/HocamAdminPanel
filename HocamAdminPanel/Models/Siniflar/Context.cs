using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HocamAdminPanel.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Sorular> Sorulars { get; set; }
        public DbSet<KayitliSorular> KayitliSorulars { get; set; }

    }
}