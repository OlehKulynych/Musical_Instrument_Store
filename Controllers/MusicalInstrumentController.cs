using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musical_Instrument_Store.Data.Interfaces;
using Musical_Instrument_Store.ViewModels;
namespace Musical_Instrument_Store.Controllers
{
    public class MusicalInstrumentController: Controller
    {
        private readonly IMusicalInstrument _musicalInstrument;
        private readonly IMICategory _mICategory;

        public MusicalInstrumentController(IMusicalInstrument iMusicalInstrument, IMICategory iMICategory)
        {
            _musicalInstrument = iMusicalInstrument;
            _mICategory = iMICategory;
        }

        public ViewResult AllMusicalInstrument()
        {
            MusicalInstrumentListViewModel obj = new MusicalInstrumentListViewModel();
            obj.GetAllMusicalInstruments = _musicalInstrument.MusicalInstruments;
            return View(obj);
        }

    }

}
