using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementSystem.Classes
{
    class ConnectionStrings
    {

        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+System.IO.Path.Combine(Application.StartupPath, "../Db/ABCInstituteDB.mdf")+"; Integrated Security=True"

        public static String ABCInstituteDB
        {
            get
            {
                return
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\ABCInstituteDB.mdf") +
"; Integrated Security=True";
            }
        }
        public static String ABCDatabase
        {
            get
            {
                return
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\ABCDatabase.mdf") +
";Integrated Security=True";
            }
        }

        public static String TimeTableSystem
        {
            get
            {
                return
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\TimeTableSystem.mdf") +
";Integrated Security=True";
            }
        } public static String Database1
        {
            get
            {
                return
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\Database1.mdf") +
";Integrated Security=True";
            }
        }

             public static String TBMS
        {
            get
            {
                return
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\TBMS.mdf") +
";Integrated Security=True";
            }

        }
    }
}
