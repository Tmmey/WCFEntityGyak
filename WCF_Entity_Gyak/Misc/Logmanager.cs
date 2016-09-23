using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Misc
{
    public static class LogManager
    {
        public static readonly ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}