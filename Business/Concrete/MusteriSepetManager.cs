using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class MusteriSepetManager : IMusteriSepetService
    {
        IMusteriDal _musteriDal;
        ISepetDal _sepetDal;
        ISepetUrunDal _sepetUrunDal;
        List<Musteri> musteriler = new List<Musteri>();
        Musteri[] musteriarray;
        List<Sepet> sepetler = new List<Sepet>();
        Sepet[] sepetlerarray;
        List<SepetUrun> sepetlerurun = new List<SepetUrun>();
        SepetUrun[] sepeturunarray;

        string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Bursa", "Edirne",
            "Konya", "Antalya", "Diyarbakır"," Van"," Rize "};
        Random random = new Random();
        string[] adsoyad = { "a", "b", "c", "d" };
        int [] adet = { 1, 2, 3, 4, 5 };
        int[] tutar = { 100, 101, 102,,103,104,105, 1000 };
        int counter = 0;
        public MusteriSepetManager(IMusteriDal musteridal, ISepetDal sepetdal,ISepetUrunDal sepeturundal)
        {
            _musteriDal = musteridal;
            _sepetUrunDal = sepeturundal;
            _sepetDal = sepetdal;
        }

        public IResult TestVerisiOlustur(int musteriAdet, int sepetAdet)
        {
            for (int i = 0; i < musteriAdet; i++)
            {
                int num = random.Next(4);
                musteriler.Add(new Musteri
                {
                    Ad = adsoyad[num],
                    Soyad = adsoyad[num],
                    Sehir = sehirler[num]
                });
                musteriarray = musteriler.ToArray();
                _musteriDal.Add(musteriarray[i]);
            }
            for(int j = 0; j < sepetAdet; j++)
            {
                
                int num2 = random.Next(musteriarray.Length-1);
                int adetrandom= random.Next(4);
                sepetler.Add(new Sepet
                {
                    MusteriId = musteriarray[num2].Id
                });
                sepetlerarray = sepetler.ToArray();
                _sepetDal.Add(sepetlerarray[j]);

                for (int k=0; k <adet[adetrandom]; k++)
                {

                    int tutarrandom = random.Next(tutar.Length-1);
                    sepetlerurun.Add(new SepetUrun
                    {
                        SepetId = sepetlerarray[j].Id,
                        Tutar = tutar[tutarrandom],
                    });
                    sepeturunarray = sepetlerurun.ToArray();
                     _sepetUrunDal.Add(sepetlerurun[counter]);
                    
                        counter++;
                }   
            }
            return new SuccesResult();
        }
    }
}
