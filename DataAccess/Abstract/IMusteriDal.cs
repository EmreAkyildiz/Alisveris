using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Entities;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IMusteriDal:IEntityRepository<Musteri>
    {
        List<DtoSehirAnaliz> SehirBazliAnalizYap();


    }
}
