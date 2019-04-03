using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Administrator
{
    public string adminName;
    public int adminID;
    private string adminPassword;
    public bool account;
    public Administrator()
    {

    }
    public Administrator(string theAdminName, int theAdminID, bool theAccount)
    {
        adminName = theAdminName;
        adminID = theAdminID;
        account = theAccount;
    }
    public string getAdminName()
    {
        return adminName;
    }
    public int getAdminID()
    {
        return adminID;
    }
    public bool getAccount()
    {
        return account;
    }
    public void setAdminName(string theAdminName)
    {
        adminName = theAdminName;
    }
    public void setAdminID(int theAdminID)
    {
        adminID = theAdminID;
    }
    public void setAccount(bool theAccount)
    {
        account = theAccount;
    }
    public void logIn()
    {
        
    }
    public void logOff()
    {
        
    }
    public void addRecord()
    {
        
    }
    public void deleteRecord()
    {
        
    }
    public void insertRecord()
    {
        
    }
    public void modifyRecord()
    {
        
    }
    public void browseRecord()
    {
        
    }
    public void checkGPA()
    {
        
    }
}
