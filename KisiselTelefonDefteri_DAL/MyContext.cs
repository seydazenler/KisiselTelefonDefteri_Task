﻿using KisiselTelefonDefteri_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselTelefonDefteri_DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon")
        {
        }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
