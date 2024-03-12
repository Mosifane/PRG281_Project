/*
Oratile Hlatshwayo - 577279
Omphile Tladi - 577776
Mosifane Mosifane - 577306
*/
using BelgiumCampusProject.BusinessLogic;
using BelgiumCampusProject.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgiumCampusProject.PresentationLayer
{
    public partial class main : Form
    {
        DataHandler handler = new DataHandler();
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bC_ProjectDBDataSet2.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter1.Fill(this.bC_ProjectDBDataSet2.Students);
            // TODO: This line of code loads data into the 'bC_ProjectDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.bC_ProjectDBDataSet.Students);

        }

        //---Deleting a student---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(txtDeleteID.Text));
            MessageBox.Show($"Student {txtDeleteID.Text} has been deleted");
        }

        //Search for a student using their StudentID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.Search(int.Parse(txtSearchID.Text));

            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDOB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtGender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtModule.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();


        }

        //Reset button to clear all textboxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtDOB.Clear();
            txtGender.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtModule.Clear();
            txtDeleteID.Clear();
            txtSearchID.Clear();

            dataGridView1.DataSource = handler.FetchAllStudents();
        }

        //Update a student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(int.Parse(txtStudentID.Text), txtName.Text, txtSurname.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtAddress.Text, txtModule.Text);

            handler.UpdateStudent(newStudent);

            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDOB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtGender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtModule.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        //terminate/close the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(int.Parse(txtStudentID.Text), txtName.Text, txtSurname.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtAddress.Text, txtModule.Text);

            handler.InsertStudent(newStudent);

            txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDOB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtGender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtModule.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        //Module Page
        private void btnModules_Click(object sender, EventArgs e)
        {
            ModulesPage form = new ModulesPage();
            form.Show();
        }
    }
}
