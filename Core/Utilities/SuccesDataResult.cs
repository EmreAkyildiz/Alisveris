using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccesDataResult<T>:DataResult<T>
    {
        public SuccesDataResult(T data) : base(data, true)
        {

        }
    }
}
