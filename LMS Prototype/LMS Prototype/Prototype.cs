using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentNamespace;
using Microsoft.VisualBasic;
using AdministratorNameSpace;

namespace LMS_Prototype
{
    public partial class Prototype : Form
    {
        DataTable table = new DataTable();

        public static bool isAdmin = false;

        //Create student object
        Student studentA = new Student();
        Administrator admin = new Administrator();

        

        public Prototype()
        {
            string adminName = "";
            string password = "";

            while (!(adminName.Equals("admin")))
            {
                adminName = Interaction.InputBox("Enter user name: ", "LogIn", "", 500, 300);

                if (adminName.Equals("admin"))
                    adminName = "admin";
                else
                    MessageBox.Show("User not found. Try again.");
            }

            while (!(password.Equals("1234")))
            {
                password = Interaction.InputBox("Enter password: ", "Password", "", 500, 300);

                if (password.Equals("1234"))
                    password = "1234";
                else
                    MessageBox.Show("Password not found. Try again.");
            }







            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void insert(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            int ID = 0;
            string name = "";
            double GPA = 3.5;

            ID = int.Parse(Interaction.InputBox("Enter ID: ", "Row Input", "", 500, 300));

            //name = Interaction.InputBox("Enter name: ", "Row Input", "", 500, 300);

            //GPA = double.Parse(Interaction.InputBox("Enter GPA: ", "Row Input", "", 500, 300));

            

            DataRow dr = table.NewRow();
            dr[0] = ID;
            //dr[1] = name;
            //dr[2] = GPA;
            table.Rows.InsertAt(dr, rowIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void add(object sender, EventArgs e)
        //Purpose: add a row (at end)
        {
            //ask & verify ID, name, GPA, exams...

            table.Rows.Add(6, "Student F", 1.0, 1, 1, 1, 1, 1, 1, 1, 1, 1);
        }

        private void delete(object sender, EventArgs e)
        //Purpose: delete selected row
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            table.Rows.RemoveAt(rowIndex);
        }

        private void logOff(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}