using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        IResult Add(Musteri musteri);
        IDataResult<List<DtoSehirAnaliz>> SehirBazliAnalizYap();
    }
}
