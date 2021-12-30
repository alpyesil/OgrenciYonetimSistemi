using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciYonetimSistemiV5
{
    class DersNotu
    {
        public DERS DersAdi { get; set; }

        private int _not;
        public int Not
        {
            get
            {
                return _not;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _not = value;
                }
                else
                {
                    throw new Exception("0 ve 100 arasında değer girilmedi.");
                }
            }
        }

        public DersNotu(DERS ders, int not)
        {
            this.DersAdi = ders;
            this.Not = not;
        }

    }


    public enum DERS
    {
        Empty,
        Turkce,
        Matematik,
        Fen,
        Sosyal
    }

}
