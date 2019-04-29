using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNamespace
{
    public class Course
    {
        private string courseName;
        private int exam1;
        private int exam2;
        private int exam3;

        public Course()
        {
            courseName = "dummy course";
            exam1 = 0;
            exam2 = 0;
            exam3 = 0;
        }

        public Course(string courseName, int exam1, int exam2, int exam3)
        {
            this.courseName = courseName;
            this.exam1 = exam1;
            this.exam2 = exam2;
            this.exam3 = exam3;
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

        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public void setExam1(int theExam1)
        {
            exam1 = theExam1;
        }

        public void setExam2(int theExam2)
        {
            exam2 = theExam2;
        }

        public void setExam3(int theExam3)
        {
            exam3 = theExam3;
        }
    }
}