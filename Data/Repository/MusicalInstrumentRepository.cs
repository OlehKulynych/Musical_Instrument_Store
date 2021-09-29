using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musical_Instrument_Store.Data.Interfaces;
using Musical_Instrument_Store.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Musical_Instrument_Store.Data.Repository
{
    public class MusicalInstrumentRepository : IMusicalInstrument
    {
        private readonly AppDBContext appDBContext;
        public MusicalInstrumentRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<MusicalInstrument> MusicalInstruments => appDBContext.MusicalInstruments.Include(c=>c.MICategory);

        public MusicalInstrument GetMIbyId(int miId) => appDBContext.MusicalInstruments.FirstOrDefault(p => p.Id == miId);
       
    }
}
