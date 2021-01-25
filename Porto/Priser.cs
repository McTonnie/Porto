using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    class Priser
    {
        //satser normal Danmark "h" står for højest
        public static double h50 = 8.5;
        public static double h100 = 17;
        public static double h250 = 34;
        public static double h2000 = 44;

        //quikbreve (prioritet A) "q" står for quik

        public static double hq100 = 28.5;
        public static double hq250 = 57.0;
        public static double hq2000 = 75;



        //satser normal Udlandet quik kan ikke sendes til udlandet
        public static double h50u = 27;
        public static double h100u = 30;
        public static double h250u = 45;
        public static double h2000u = 79;
    }
}
