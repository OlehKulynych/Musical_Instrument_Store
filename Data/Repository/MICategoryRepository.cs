using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musical_Instrument_Store.Data.Interfaces;
using Musical_Instrument_Store.Data.Models;

namespace Musical_Instrument_Store.Data.Repository
{

    public class MICategoryRepository : IMICategory
    {
        private readonly AppDBContext appDBContext;
        public MICategoryRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<MICategory> GetAllCategories => appDBContext.mICategories;
    }

}
