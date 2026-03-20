using DC.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.General_class_infos
{
    public class clsGeneral_class_infos
    {
        private static clsUser _User;

        public static clsUser User
        {
            get { return _User; }
        }   
        public static void  LoadUserClassInfo(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);
        }

    }
}
