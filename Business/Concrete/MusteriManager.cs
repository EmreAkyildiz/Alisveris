using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _MusteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _MusteriDal = musteriDal;
        }
        public IResult Add(Musteri musteri)
        {
            _MusteriDal.Add(musteri);
            return new SuccesResult();
        }

        public IDataResult<List<DtoSehirAnaliz>> SehirBazliAnalizYap()
        {
            return new SuccesDataResult<List<DtoSehirAnaliz>>(_MusteriDal.SehirBazliAnalizYap());
        }
    }
}
