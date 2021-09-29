using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musical_Instrument_Store.Data.Models;
namespace Musical_Instrument_Store.ViewModels
{
    public class MusicalInstrumentListViewModel
    {
        public IEnumerable<MusicalInstrument> GetAllMusicalInstruments { get; set; }
        public string currentCategoty { get; set; }
    }
}
