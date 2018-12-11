using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilausotsikot
{
    class TilausRivi
    {
         


        //GET SET
        public int tilausID { get; set; }

        public int pakkausmaara { get; set; }

        public int yksikkohinta { get; set; }

        public int varastomaara { get; set; }

        public int varastoarvo { get; set; }

        public string tilausnimi { get; set; }


    }
}

