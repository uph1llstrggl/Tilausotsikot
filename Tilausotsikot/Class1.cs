using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilausotsikot
{
    class Tilausotsikko
    {
        private int Tilausnumero;

        //GET SET
        public int tilausnumero
        {
            get
            {
                return Tilausnumero;
            }
            set
            {
                if (value > 0 && value < 400)
                {
                    Tilausnumero = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();

                }
            }
        }


        public int tuotenumero { get; set; }

        public string asiakasNimi { get; set; }

        public DateTime tilauspvm { get; set; }

        public DateTime toimituspvm { get; set; }

        public string toimitusosoite { get; set; }


    }
}
