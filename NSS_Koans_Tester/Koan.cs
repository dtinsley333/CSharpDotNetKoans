using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSS_Koans_Tester
{

        public class Koan
        {
            public bool FillIn;
            public int Fill_In_Number;
            public List<int> Fill_In;
            public static object FILL_ME_IN = new Object();
        }

        //This is just used when we need a type
        public abstract class FillMeIn
        {

        }
    
}
