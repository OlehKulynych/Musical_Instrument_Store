using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musical_Instrument_Store.Data.Models;

namespace Musical_Instrument_Store.Data.Interfaces
{
    public interface IMusicalInstrument
    {
        IEnumerable<MusicalInstrument> MusicalInstruments { get; }
        MusicalInstrument GetMIbyId(int miId); 
    }
}
