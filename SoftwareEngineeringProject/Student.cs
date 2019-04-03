using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Inheritence from Course */

public class Student
{
    public string studentName;
    public int studentID;
    private string studentPassword;
    public string registeredCourses;
    public int examScores;
    public double GPACalculation;
    public bool account;
    public Student()
    {

    }
    public Student(string theStudentName, int theStudentID, string theStudentPassword, string theRegisteredCourses, int theExamScores, double theGPACalculation, bool theAccount)
    {
        studentName = theStudentName;
        studentID = theStudentID;
        studentPassword = theStudentPassword;
        registeredCourses = theRegisteredCourses;
        examScores = theExamScores;
        GPACalculation = theGPACalculation;
        account = theAccount;
    }
    public string getStudentName()
    {
        return studentName;
    }
    public int getStudentID()
    {
        return studentID;
    }
    public string getRegisteredCourses()
    {
        return registeredCourses;
    }
    public int getExamScores()
    {
        return examScores;
    }
    public double getGPACalculation()
    {
        return GPACalculation;
    }
    public bool getAccount()
    {
        return account;
    }
    public void setStudentName(string theStudentName)
    {
        studentName = theStudentName;
    }
    public void setStudentID(int theStudentID)
    {
        studentID = theStudentID;
    }
    public void setRegisteredCourses(string theRegisteredCourses)
    {
        registeredCourses = theRegisteredCourses;
    }
    public void setExamScores(int theExamScores)
    {
        examScores = theExamScores;
    }
    public void setGPACalculation(double theGPACalculation)
    {
        GPACalculation = theGPACalculation;
    }
    public void setAccount(bool theAccount)
    {
        account = theAccount;
    }
    public void account()
    {
        
    }
    public void logIn()
    {
        
    }
    public void logOff()
    {
        
    }
    public void viewRecord()
    {
        
    }
}
