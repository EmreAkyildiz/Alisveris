using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces.EfEntityRepositoryBase;
using DataAccess.Abstract;
using Entities;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Core.Utilities;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfMusteriDal : EfEntityRepositoryBase<Musteri, SQLContext>, IMusteriDal
    {
        public List<DtoSehirAnaliz> SehirBazliAnalizYap()
        {
            using (SQLContext context = new SQLContext())
            {
                var result = from m in context.Musteri
                             join s in context.Sepet
                             on m.Id equals s.MusteriId 
                             
                             select new DtoSehirAnaliz
                             {
                                 Sehir=m.Sehir,
                                 SepetAdedi=0,
                                 ToplamTutar=0 
                             };
                return result.ToList();


            }
        }
    }
}
