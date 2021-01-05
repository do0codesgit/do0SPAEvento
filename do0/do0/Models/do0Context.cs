﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using do0.Models;

//using do0.Migrations;

namespace do0.Models
{
    public class do0Context : DbContext
    {
        public do0Context()
            : base("do0Context")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<do0Context, Configuration>());
            Database.SetInitializer<do0Context>(new DropCreateDatabaseIfModelChanges<do0Context>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseAlways<do0Context>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseIfModelChanges<do0Context>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseAlways<do0Context>());
            //Database.SetInitializer<do0Context>(new do0DbInicializador());
        }

        public DbSet<do0Evento> do0Eventos { get; set; }
        public DbSet<do0TipoEvento> do0TipoEventos { get; set; }

        public System.Data.Entity.DbSet<do0.Models.do0EventoPagamento> do0EventoPagamento { get; set; }
    }
}