using Musical_Instrument_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musical_Instrument_Store.Data.Interfaces
{
    public interface IMICategory
    {
        IEnumerable<MICategory> GetAllCategories { get; } 
    }
}
