using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Administrator
{
    public string adminName;
    public Administrator()
    {

    }
    public Administrator(string theAdminName)
    {
        adminName = theAdminName;
    }
    public string getAdminName()
    {
        return adminName;
    }
    public void setAdminName(string theAdminName)
    {
        adminName = theAdminName;
    }
}
