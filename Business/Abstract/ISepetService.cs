using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities;

namespace Business.Abstract
{
    public interface ISepetService
    {
        IResult Add(Sepet sepet);
    }
}
