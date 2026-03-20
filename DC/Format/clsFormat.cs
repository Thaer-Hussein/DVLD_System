using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBuisness.Format
{
    public class clsFormat
    {
        static public bool CheckTheEmailFormat(string email)
        {
            return email.EndsWith("@gmail.com");
        }

        static public bool CheckThePhoneFormat(string phone)
        {
            bool isNumber = int.TryParse(phone, out _);
            return phone.StartsWith("07") && phone.Length == 10 && isNumber;
        }


        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }

        //public static string DateToShort(DateTime? dateOfBirth)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
