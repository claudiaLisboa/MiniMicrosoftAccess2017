using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMicrosoftAccess2017
{
    // this class provides access to myDB to all Forms. We create and use it's instance (which we make a global var)
    public static class clsGlobal
    {
        public static DAO.Database myDB;
    }   
}
