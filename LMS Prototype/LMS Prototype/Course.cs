using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Course
{
  public string courseName;
  public int exam1;
  public int exam2;
  public int exam3;
  public Course()
  {
  
  }
  public Course(string theCourseName, int theExam1, int theExam2, int theExam3)
  {
    courseName = theCourseName;
    exam1 = theExam1;
    exam2 = theExam2;
    exam3 = theExam3;
  }
  public string getCourseName()
  {
    return courseName;
  }
  public int getExam1()
  {
    return exam1;
  }
  public int getExam2()
  {
    return exam2;
  }
  public int getExam3()
  {
    return exam3;
  }
  public void setCourseName(string theCourseName)
  {
    courseName = theCourseName;
  }
  public void setExam1(int theExam1)
  {
    exam1 = theExam1;
  }
  public void setExam2(int theExam2)
  {
    exam2 = theExam2;;
  }
  public void setExam3(int theExam3)
  {
    exam3 = theExam3;
  }
}
