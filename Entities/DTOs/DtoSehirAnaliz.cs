using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class DtoSehirAnaliz:IDto
    {
        public string Sehir { get; set; }
        public int SepetAdedi { get; set; }
        public int ToplamTutar { get; set; }
    }
}
