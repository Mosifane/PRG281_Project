/*
Oratile Hlatshwayo - 577279
Omphile Tladi - 577776
Mosifane Mosifane - 577306
*/
using BelgiumCampusProject.DataLayer;
using BelgiumCampusProject.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgiumCampusProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            List<string> users = new List<string>();//create a new list for the users in the file
            string[] userDetails = new string[2];//create an array for the username and password

            users = handler.readFromFile(); //fill the list with whats in the text file 

            bool found = false;

            for (int i = 0; i < users.Count; i++)
            {
                userDetails = users[i].Split(',');

                if (textBox1.Text == userDetails[0] && textBox2.Text == userDetails[1])//look for a match 
                {
                    //if (textBox2.Text == userDetails[1])//if the username exists check for the password
                    //{
                        found = true;
                    if (found == true)
                    {
                        MessageBox.Show("Correct credentials");
                        main form = new main();//show the main form 
                        form.Show();
                        break;
                    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Password was incorrect");

                    //}
                }
                else
                {
                    MessageBox.Show("This user does not exist\nOr\nThe user name was spelled incorrect");
                    
                }
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            handler.writeToFile(textBox1.Text, textBox2.Text);
        }
    }
}

    //create a new user and write them to the textFile
 

