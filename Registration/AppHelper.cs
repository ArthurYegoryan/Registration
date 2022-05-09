using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Registration
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.
            ConnectionStrings["Registration.Properties.Settings.RegistrationDBConnectionString"].ConnectionString;
    }
}
