using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data):base(data,false)
        {

        }
    }
}
