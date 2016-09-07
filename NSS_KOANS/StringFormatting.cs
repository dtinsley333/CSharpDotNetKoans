using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSS_KOANS
{
    class StringFormatting
    {

        public string FormatPhoneNumber(string phone)
        {
            var formattedPhone= String.Format("{0:(###) ###-####}", phone);
            return formattedPhone;
        }
    }
}
