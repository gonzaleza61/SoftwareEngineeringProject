using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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







            /* Click button to show table with data
                DataTable dt = new DataTable();

                dt.Columns.Add("Name");
                dt.Columns.Add("Address");
                dt.Columns.Add("Occupation");
                dt.Columns.Add("Salary");

                dataGridView1.DataSource = dt;

                dt.Rows.Add(new object[] { "John", "London", "Author", 30000 });
                dt.Rows.Add(new object[] { "Lynda", "London", "Designer", 40000 });
                dt.Rows.Add(new object[] { "Avril", "London", "Programmer", 50000 });
                dt.Rows.Add(new object[] { "Chris", "London", "Author", 30000 });

            */
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

            table.Rows.Add(1, "Student A", 3.99, 100, 100, 100, 100, 100, 100, 100, 100, 99);
            table.Rows.Add(2, "Student B", 3.01, 80, 80, 80, 80, 80, 80, 80, 80, 88);
            table.Rows.Add(3, "Student C", 2.01, 70, 70, 70, 70, 70, 70, 70, 70, 77);
            table.Rows.Add(4, "Student D", 1.01, 60, 60, 60, 60, 60, 60, 60, 60, 66);
            table.Rows.Add(5, "Student E", 0.01, 0, 0, 0, 0, 0, 0, 0, 0, 1);

            /*
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);
            */

            dataGridView1.DataSource = table;







            /*
             *Backup code for simple table
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));


            table.Rows.Add(1, "First A", "Last A", 10);
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);

            dataGridView1.DataSource = table;
            */
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
