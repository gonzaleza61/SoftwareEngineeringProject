using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentNamespace;

namespace LMS_Prototype
{
    public partial class Prototype : Form
    {
        public Prototype()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("GPA", typeof(float));
            table.Columns.Add("Exam 1 (15%)", typeof(int));
            table.Columns.Add("Exam 2 (15%)", typeof(int));
            table.Columns.Add("Exam 3 (20%)", typeof(int));

            table.Columns.Add("Exam 1 (10%)", typeof(int));
            table.Columns.Add("Exam 2 (10%)", typeof(int));
            table.Columns.Add("Exam 3 (30%)", typeof(int));

            table.Columns.Add("Exam 1 (8%)", typeof(int));
            table.Columns.Add("Exam 2 (8%)", typeof(int));
            table.Columns.Add("Exam 3 (50%)", typeof(int));

            //Create student object
            Student studentA = new Student();

            //Output sample of studentA using Student methods onto GUI
            table.Rows.Add(studentA.getID(), "Student A", studentA.getGPA(), studentA.getCourse1().getExam1(), studentA.getCourse1().getExam2(), studentA.getCourse1().getExam3(), 100, 100, 100, 100, 100, 99);
            //table.Rows.Add(1, "Student A", 3.99, 100, 100, 100, 100, 100, 100, 100, 100, 99); somewhat equivalent to the row above

            table.Rows.Add(2, "Student B", 3.01, 80, 80, 80, 80, 80, 80, 80, 80, 88);
            table.Rows.Add(3, "Student C", 2.01, 70, 70, 70, 70, 70, 70, 70, 70, 77);
            table.Rows.Add(4, "Student D", 1.01, 60, 60, 60, 60, 60, 60, 60, 60, 66);
            table.Rows.Add(5, "Student E", 0.01, 0, 0, 0, 0, 0, 0, 0, 0, 1);

            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
