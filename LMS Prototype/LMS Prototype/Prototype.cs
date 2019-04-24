using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using StudentNamespace;
using AdministratorNameSpace;
using CourseNamespace;

namespace LMS_Prototype
{
    public partial class Prototype : Form
    {
        DataTable table = new DataTable();    

        public static bool isAdmin = false;
        public static bool isStudent = false;

        //Create student object
        Student bob = new Student("Bob", 1, "bob", 3.99, true);


        
        Administrator admin = new Administrator();

        

        public Prototype()
        {
            
            string name = "";
            string password = "";
            bool isNameFound = false;

            //Check if an administrator is logging in

            //while (!(name.Equals("admin")) && !(name.Equals("bob")))

            while (!isNameFound)
            {
                name = Interaction.InputBox("Enter user name: ", "Login (user: admin or bob, pass: 1234)", "", 500, 300);     //check code

                if (name.Equals("admin"))
                {
                    isAdmin = true;
                    name = "admin";
                    isNameFound = true;
                }
                    
                else if (name.Equals("bob"))
                {
                    isStudent = true;
                    name = "bob";
                    isNameFound = true;
                }
                    
                else
                    MessageBox.Show("User not found. Try again.");
            }

            while (!(password.Equals("1234")))
            {
                password = Interaction.InputBox("Enter password: ", "Password (user: admin or bob, pass: 1234)", "", 500, 300);    //check code

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
            table.Columns.Add("[1]\nCS3304 Data & Info. Struc. \n\nExam 1", typeof(int));
            table.Columns.Add("[1]\nCS3304 Data & Info. Struc. \n\nExam 2", typeof(int));
            table.Columns.Add("[1]\nCS3304 Data & Info. Struc. \n\nExam 3", typeof(int));

            table.Columns.Add("[2]\nCS3306 Theory of Comp. \n\nExam 1", typeof(int));
            table.Columns.Add("[2]\nCS3306 Theory of Comp. \n\nExam 2", typeof(int));
            table.Columns.Add("[2]\nCS3306 Theory of Comp. \n\nExam 3", typeof(int));

            table.Columns.Add("[3]\nCS4315 Operating Systems \n\nExam 1", typeof(int));
            table.Columns.Add("[3]\nCS4315 Operating Systems \n\nExam 2", typeof(int));
            table.Columns.Add("[3]\nCS4315 Operating Systems \n\nExam 3", typeof(int));

            table.Columns.Add("[4]\nCS4318 Database Systems \n\nExam 1", typeof(int));
            table.Columns.Add("[4]\nCS4318 Database Systems \n\nExam 2", typeof(int));
            table.Columns.Add("[4]\nCS4318 Database Systems \n\nExam 3", typeof(int));



            //Output sample of studentA using Student methods onto GUI
            //table.Rows.Add(bob.getID(), "Bob", bob.getGPA(), bob.getCourse1().getExam1(), bob.getCourse1().getExam2(), bob.getCourse1().getExam3(), 100, 100, 100, 100, 100, 99);

            if(isStudent)
            {
                table.Rows.Add(1, "Bob", 3.75, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 99);
            }

            else if(isAdmin)
            {
                table.Rows.Add(1, "Bob", 3.75, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 99);
                table.Rows.Add(2, "Cob", 3.50, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 88);
                table.Rows.Add(3, "Dob", 3.00, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 77);
                table.Rows.Add(4, "Fob", 2.50, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 66);
                table.Rows.Add(5, "Gob", 2.00, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 55);
                table.Rows.Add(6, "Hob", 1.50, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 44);
                table.Rows.Add(7, "Job", 1.25, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 33);
                table.Rows.Add(8, "Kob", 1.00, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 22);
                table.Rows.Add(9, "Lob", 0.10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11);
                table.Rows.Add(10, "Mob", 0.05, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);
                table.Rows.Add(11, "Nob", 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
            

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
            if(isStudent)
            {
                MessageBox.Show("Access Denied.  You must be an Administrator to insert a record.");
            }

            else if(isAdmin)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                int ID = 0;
                //string name = "";
                //double GPA = 3.5;

                ID = int.Parse(Interaction.InputBox("Enter ID: ", "Row Input", "", 500, 300));

                //name = Interaction.InputBox("Enter name: ", "Row Input", "", 500, 300);

                //GPA = double.Parse(Interaction.InputBox("Enter GPA: ", "Row Input", "", 500, 300));



                DataRow dr = table.NewRow();
                dr[0] = ID;
                dr[1] = "Enter Info";
                //dr[2] = GPA;
                table.Rows.InsertAt(dr, rowIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void add(object sender, EventArgs e)
        //Purpose: add a row (at end)
        {
            //ask & verify ID, name, GPA, exams...

            if (isStudent)
            {
                MessageBox.Show("Access Denied.  You must be an Administrator to add a record.");
            }

            else if(isAdmin)
            {
                table.Rows.Add(0, "Enter Info", 0.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
        }

        private void delete(object sender, EventArgs e)
        //Purpose: delete selected row
        {
            if (isStudent)
            {
                MessageBox.Show("Access Denied.  You must be an Administrator to delete a record.");
            }

            else if(isAdmin)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                table.Rows.RemoveAt(rowIndex);
            }
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