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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgiumCampusProject.PresentationLayer
{
    public partial class ModulesPage : Form
    {
        DataHandler handler = new DataHandler();
        public ModulesPage()
        {
            InitializeComponent();
        }

        private void ModulesPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bC_ProjectDBDataSet3.Modules' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.bC_ProjectDBDataSet3.Modules);

        }

        //display all modules
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.FetchAllModules();
            txtDeleteMod.Clear();
            txtModCode.Clear();
            txtModDescription.Clear();
            txtModName.Clear();
            txtSearchMod.Clear();
        }
        //Update a module
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Modules mod = new Modules(txtModCode.Text, txtModName.Text, txtModDescription.Text);

            handler.Updatemodule(mod);                   
        }

        //adding/creating a new modules
        private void btnAddModule_Click(object sender, EventArgs e)
        {
         //   string modCode = "[" + txtModCode.Text + "]";
           // string modName = "[" + txtModName.Text + "]";
            //tring modDescription = "[" + txtModDescription.Text + "]";
            Modules mod = new Modules(txtModCode.Text, txtModName.Text, txtModDescription.Text);

            handler.InsertModule(mod);
        }

        //Delete a Module
        private void btnDelete_Click(object sender, EventArgs e)
        {
           // string toDelete = "'" + txtDeleteMod.Text + "'";
            handler.DeleteModule(txtDeleteMod.Text);
        }

        //Search for a Module
        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = handler.ModuleSearch(txtSearchMod.Text);

            //txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtModCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtModName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtModDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
