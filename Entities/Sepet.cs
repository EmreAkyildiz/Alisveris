using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities
{
    public class Sepet : IEntity
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
    }
}
