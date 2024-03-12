/*
Oratile Hlatshwayo - 577279
Omphile Tladi - 577776
Mosifane Mosifane - 577306
*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelgiumCampusProject.BusinessLogic;
using System.Windows.Forms;

namespace BelgiumCampusProject.DataLayer
{
    internal class DataHandler
    {
        string conn = "Data Source=DESKTOP-F94U4BA\\SQLEXPRESS;Initial Catalog=BC_ProjectDB;Integrated Security=True";

        DataTable dataTable;
        SqlDataAdapter adapter;
        string query;

        public DataTable FetchAllStudents()
        {
            query = @"SELECT * FROM Students";

            adapter = new SqlDataAdapter(query, conn);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable FetchAllModules()
        {
            query = @"SELECT * FROM Modules";

            adapter = new SqlDataAdapter(query, conn);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable Search(int StudentNumber)
        {
            query = $"SELECT * FROM Students WHERE StudentNumber = {StudentNumber}";

            adapter = new SqlDataAdapter(query, conn);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable ModuleSearch(string moduleCode)
        {
            string toSearch = "'" + moduleCode + "'";
            query = $"SELECT * FROM Modules WHERE ModuleCode = {toSearch}";

            adapter = new SqlDataAdapter(query, conn);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public void InsertStudent(Student student)
        {
            try
            {
                query = $"INSERT INTO Students (StudentNumber, FirstName, Surname, DateOfBirth, Phone, Address, ModuleCode) VALUES ('{student.StudentNumber}', '{student.FirstName}', '{student.Surname}', '{student.DateofBirth}', '{student.Phone}', '{student.Address}', '{student.ModuleCodes}')";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show("New student inserted");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void InsertModule(Modules module)
        {
            try
            {
                query = $"INSERT INTO Modules (ModuleCode, ModuleName, ModuleDescription) VALUES ('{module.ModuleCode}', '{module.ModuleName}', '{module.ModuleDescription}')";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show("New Module added");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {
                query = $"DELETE FROM Students WHERE StudentNumber = {id}";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show($"The student: {id} has been deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
        }

        public void DeleteModule(string modCode)
        {
            try
            {
                query = $"DELETE FROM Modules WHERE ModuleCOde = '{modCode}'";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show($"The module {modCode} has been deleted");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                query = $"UPDATE Students SET FirstName = '{student.FirstName}', Surname = '{student.Surname}', DateofBirth = '{student.DateofBirth}', Phone = '{student.Phone}', Gender = '{student.Gender}', Address = '{student.Address}', ModuleCode = '{student.ModuleCodes}' WHERE StudentNumber = {student.StudentNumber}";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show($"student {student.StudentNumber} has been updated");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
        }

        public void Updatemodule(Modules module)
        {

            try
            {
                query = $"UPDATE Modules SET ModuleCode = '{module.ModuleCode}', ModuleName = '{module.ModuleName}', ModuleDescription = '{module.ModuleDescription}' WHERE ModuleCode = '{module.ModuleCode}'";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show($"Module {module.ModuleCode} has been updated");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
