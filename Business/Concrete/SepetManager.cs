using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class SepetManager : ISepetService
    {
        ISepetDal _sepetDal;
        public SepetManager(ISepetDal sepetDal)
        {
            _sepetDal = sepetDal;
        }
        public IResult Add(Sepet sepet)
        {
            _sepetDal.Add(sepet);
            return new SuccesResult();
        }
    }
}
