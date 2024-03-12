/*
Oratile Hlatshwayo - 577279
Omphile Tladi - 577776
Mosifane Mosifane - 577306
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgiumCampusProject.DataLayer
{
    internal class FileHandler
    {
        string usersFile = @"UsersDetails.txt";
        //Read From the File (Format: username, password)
        public List<string> readFromFile()
        {
            List<string> data = new List<string>();
            data = File.ReadAllLines(usersFile).ToList();

            return data;
        }

        public void writeToFile(string name, string password)
        {
             string newUser = name + "," + password;

            using (StreamWriter sw = File.AppendText(usersFile))
            {
                sw.WriteLine(newUser);
            }
            MessageBox.Show("A new user has successfully been added");
        }

    }
}
