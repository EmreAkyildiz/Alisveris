using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces.EfEntityRepositoryBase;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete
{
    public class EfSepetUrunDal:EfEntityRepositoryBase<SepetUrun,SQLContext>,ISepetUrunDal
    {
    }
}
