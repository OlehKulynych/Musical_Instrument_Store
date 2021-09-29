﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Musical_Instrument_Store.Data.Models;

namespace Musical_Instrument_Store.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<MusicalInstrument> MusicalInstruments { get; set; }
        public DbSet<MICategory> mICategories { get; set; }
    }
}
