using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities
{
    public class SepetUrun:IEntity
    {
        public int Id { get; set; }
        public int SepetId { get; set; }
        public int Tutar { get; set; }
        public string Aciklama { get; set; }
    }
}
