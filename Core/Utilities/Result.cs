using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool succes)
        {
            Succes = succes;
        }
       public bool Succes { get; }
    }
}
