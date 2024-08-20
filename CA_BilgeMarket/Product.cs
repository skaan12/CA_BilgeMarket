using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_BilgeMarket
{
    public class Product
    {
        private decimal _fiyat;

        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }


            set
            {
                _fiyat = value;
            }
        }
        public decimal KdvFiyat
        {
            get
            {
                return (_fiyat * 1.2m);

            }
        }

        public string Type { get; set; }
    }
    


}

