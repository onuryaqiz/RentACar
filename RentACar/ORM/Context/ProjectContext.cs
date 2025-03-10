﻿using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Context
{
    public class ProjectContext : DbContext
    {
        // Veritabanına bağlanma ve Code First Yöntemi ile Entitylerimizi tablo olarak veritabanına yollama.
        public ProjectContext() 
        {
            Database.Connection.ConnectionString = "Server=202-HOCAPC;Database=RentACar;uid=sa;pwd=1453";
        }

        // Migration adımları
        // enable-migrations
        // add-migration 'init'
        // update-database

        public DbSet<Arabalar> Arabalars { get; set; }

        public DbSet<Yoneticiler> Yoneticilers { get; set; }

        public DbSet<Kiralamalar> Kiralamalars { get; set; }
    }
}
