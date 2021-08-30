using System;
using System.Text;
using Core.Entities;
using Core.Utilities;


namespace Business.Abstract
{
    public interface IMusteriSepetService
    {
        IResult TestVerisiOlustur(int musteriAdet, int sepetAdet);
        
    }
}
