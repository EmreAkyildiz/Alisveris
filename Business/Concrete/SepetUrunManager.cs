using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class SepetUrunManager : ISepetUrunService
    {
        ISepetUrunDal _sepetUrunDal;
        public SepetUrunManager(ISepetUrunDal sepetUrunDal)
        {
            _sepetUrunDal = sepetUrunDal;
        }
        public IResult Add(SepetUrun sepeturun)
        {
            _sepetUrunDal.Add(sepeturun);
            return new SuccesResult();
        }
    }
}
