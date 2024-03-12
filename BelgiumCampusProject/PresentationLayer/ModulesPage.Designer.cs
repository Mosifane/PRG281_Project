namespace BelgiumCampusProject.PresentationLayer
{
    partial class ModulesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moduleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleLinksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bC_ProjectDBDataSet3 = new BelgiumCampusProject.BC_ProjectDBDataSet3();
            this.modulesTableAdapter = new BelgiumCampusProject.BC_ProjectDBDataSet3TableAdapters.ModulesTableAdapter();
            this.grbModuleInfo = new System.Windows.Forms.GroupBox();
            this.txtModDescription = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbDelete = new System.Windows.Forms.GroupBox();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.txtDeleteMod = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearchMod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bC_ProjectDBDataSet3)).BeginInit();
            this.grbModuleInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODULES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleCodeDataGridViewTextBoxColumn,
            this.moduleNameDataGridViewTextBoxColumn,
            this.moduleDescriptionDataGridViewTextBoxColumn,
            this.moduleLinksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modulesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // moduleCodeDataGridViewTextBoxColumn
            // 
            this.moduleCodeDataGridViewTextBoxColumn.DataPropertyName = "ModuleCode";
            this.moduleCodeDataGridViewTextBoxColumn.HeaderText = "ModuleCode";
            this.moduleCodeDataGridViewTextBoxColumn.Name = "moduleCodeDataGridViewTextBoxColumn";
            this.moduleCodeDataGridViewTextBoxColumn.Width = 92;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            this.moduleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName";
            this.moduleNameDataGridViewTextBoxColumn.HeaderText = "ModuleName";
            this.moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            this.moduleNameDataGridViewTextBoxColumn.Width = 95;
            // 
            // moduleDescriptionDataGridViewTextBoxColumn
            // 
            this.moduleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ModuleDescription";
            this.moduleDescriptionDataGridViewTextBoxColumn.HeaderText = "ModuleDescription";
            this.moduleDescriptionDataGridViewTextBoxColumn.Name = "moduleDescriptionDataGridViewTextBoxColumn";
            this.moduleDescriptionDataGridViewTextBoxColumn.Width = 120;
            // 
            // moduleLinksDataGridViewTextBoxColumn
            // 
            this.moduleLinksDataGridViewTextBoxColumn.DataPropertyName = "ModuleLinks";
            this.moduleLinksDataGridViewTextBoxColumn.HeaderText = "ModuleLinks";
            this.moduleLinksDataGridViewTextBoxColumn.Name = "moduleLinksDataGridViewTextBoxColumn";
            this.moduleLinksDataGridViewTextBoxColumn.Width = 92;
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.bC_ProjectDBDataSet3;
            // 
            // bC_ProjectDBDataSet3
            // 
            this.bC_ProjectDBDataSet3.DataSetName = "BC_ProjectDBDataSet3";
            this.bC_ProjectDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // grbModuleInfo
            // 
            this.grbModuleInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbModuleInfo.Controls.Add(this.txtModDescription);
            this.grbModuleInfo.Controls.Add(this.txtModName);
            this.grbModuleInfo.Controls.Add(this.txtModCode);
            this.grbModuleInfo.Controls.Add(this.label4);
            this.grbModuleInfo.Controls.Add(this.label3);
            this.grbModuleInfo.Controls.Add(this.label2);
            this.grbModuleInfo.ForeColor = System.Drawing.Color.White;
            this.grbModuleInfo.Location = new System.Drawing.Point(12, 367);
            this.grbModuleInfo.Name = "grbModuleInfo";
            this.grbModuleInfo.Size = new System.Drawing.Size(677, 142);
            this.grbModuleInfo.TabIndex = 2;
            this.grbModuleInfo.TabStop = false;
            this.grbModuleInfo.Text = "MODULE iNFORMATION";
            // 
            // txtModDescription
            // 
            this.txtModDescription.Location = new System.Drawing.Point(524, 69);
            this.txtModDescription.Name = "txtModDescription";
            this.txtModDescription.Size = new System.Drawing.Size(147, 20);
            this.txtModDescription.TabIndex = 5;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(264, 69);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(147, 20);
            this.txtModName.TabIndex = 4;
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(18, 69);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(147, 20);
            this.txtModCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(521, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Module Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(261, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Module Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Module Code";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(860, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 68);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAll.Location = new System.Drawing.Point(710, 441);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(144, 68);
            this.btnDisplayAll.TabIndex = 4;
            this.btnDisplayAll.Text = "DISPLAY ALL";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(710, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(289, 68);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE MODULE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSearchMod);
            this.groupBox1.Location = new System.Drawing.Point(710, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For a Module";
            // 
            // grbDelete
            // 
            this.grbDelete.Controls.Add(this.btnDelete);
            this.grbDelete.Controls.Add(this.txtDeleteMod);
            this.grbDelete.Location = new System.Drawing.Point(710, 156);
            this.grbDelete.Name = "grbDelete";
            this.grbDelete.Size = new System.Drawing.Size(289, 117);
            this.grbDelete.TabIndex = 7;
            this.grbDelete.TabStop = false;
            this.grbDelete.Text = "Delete a Module";
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.Color.Black;
            this.btnAddModule.ForeColor = System.Drawing.Color.White;
            this.btnAddModule.Location = new System.Drawing.Point(710, 293);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(289, 68);
            this.btnAddModule.TabIndex = 8;
            this.btnAddModule.Text = "INSERT MODULE";
            this.btnAddModule.UseVisualStyleBackColor = false;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // txtDeleteMod
            // 
            this.txtDeleteMod.Location = new System.Drawing.Point(16, 25);
            this.txtDeleteMod.Name = "txtDeleteMod";
            this.txtDeleteMod.Size = new System.Drawing.Size(259, 20);
            this.txtDeleteMod.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(16, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(258, 52);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE MODULE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchMod
            // 
            this.txtSearchMod.Location = new System.Drawing.Point(18, 29);
            this.txtSearchMod.Name = "txtSearchMod";
            this.txtSearchMod.Size = new System.Drawing.Size(255, 20);
            this.txtSearchMod.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEARCH MODULE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModulesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BelgiumCampusProject.Properties.Resources.Back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 533);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.grbDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbModuleInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayAll);
            this.Name = "ModulesPage";
            this.Text = "ModulesPage";
            this.Load += new System.EventHandler(this.ModulesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bC_ProjectDBDataSet3)).EndInit();
            this.grbModuleInfo.ResumeLayout(false);
            this.grbModuleInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDelete.ResumeLayout(false);
            this.grbDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BC_ProjectDBDataSet3 bC_ProjectDBDataSet3;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private BC_ProjectDBDataSet3TableAdapters.ModulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleLinksDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grbModuleInfo;
        private System.Windows.Forms.TextBox txtModDescription;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbDelete;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteMod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchMod;
    }
}