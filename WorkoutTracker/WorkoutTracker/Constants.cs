using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutTracker
{
    internal static class Constants
    {
        internal static String DBDATASOURCE = "Data Source=(LocalDB)\\MSSQLLocalDB;";
        internal static String DBATTACHDBFILENAME = "AttachDbFilename=" + Application.StartupPath + "\\WorkoutTrackerDB.mdf;";
        internal static String DBINTEGRATEDSECURITY = "Integrated Security=True;";
        internal static String DBCONNECTTIMEOUT = "Connect Timeout=5;";
    }
}
