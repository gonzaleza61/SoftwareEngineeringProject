using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Administrator
{
    private string name;
    private int ID;
    private string password;
    private bool account;

    public Administrator()
    {
        name = "dummy admin name";
        ID = 12345;
        password = "no password";
        account = true;
    }
    public Administrator(string name, int ID, string password, bool account)
    {
        this.name = name;
        this.ID = ID;
        this.password = password;
        this.account = account;
    }

    public string getName()
    {
        return name;
    }

    public int getID()
    {
        return ID;
    }

    public bool getAccount()
    {
        return account;
    }

    public void setName(string name)
    {
        this.name = name;
    }
    public void setID(int ID)
    {
        this.ID = ID;
    }
    public void setAccount(bool account)
    {
        this.account = account;
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
