using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkClassLibrary
{
    public class Utility
    {
        public static string GetProjectTypeName()
        {
            return Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["name"]);
        }
    }
}
