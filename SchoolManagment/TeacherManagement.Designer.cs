namespace SchoolManagment
{
    partial class TeacherManagement
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
            this.label7 = new System.Windows.Forms.Label();
            this.teacherDGV = new System.Windows.Forms.DataGridView();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.courseCB = new System.Windows.Forms.ComboBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.fullnameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.studentManagementBTN = new System.Windows.Forms.Label();
            this.courseManagementBTN = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(505, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 36);
            this.label7.TabIndex = 65;
            this.label7.Text = "Teacher Managment";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // teacherDGV
            // 
            this.teacherDGV.AllowUserToOrderColumns = true;
            this.teacherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDGV.Location = new System.Drawing.Point(603, 192);
            this.teacherDGV.Margin = new System.Windows.Forms.Padding(4);
            this.teacherDGV.Name = "teacherDGV";
            this.teacherDGV.RowHeadersWidth = 51;
            this.teacherDGV.Size = new System.Drawing.Size(504, 287);
            this.teacherDGV.TabIndex = 64;
            this.teacherDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherDGV_CellContentClick);
            // 
            // departmentCB
            // 
            this.departmentCB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Items.AddRange(new object[] {
            "Information Technology",
            "Accounting",
            "Engineering",
            "Business"});
            this.departmentCB.Location = new System.Drawing.Point(289, 409);
            this.departmentCB.Margin = new System.Windows.Forms.Padding(4);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(265, 24);
            this.departmentCB.TabIndex = 63;
            this.departmentCB.SelectedIndexChanged += new System.EventHandler(this.departmentCB_SelectedIndexChanged);
            // 
            // courseCB
            // 
            this.courseCB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.courseCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCB.FormattingEnabled = true;
            this.courseCB.Items.AddRange(new object[] {
            "Software Development",
            "Project Management",
            "Business Studies",
            "Physics",
            "Programming Foundation"});
            this.courseCB.Location = new System.Drawing.Point(289, 358);
            this.courseCB.Margin = new System.Windows.Forms.Padding(4);
            this.courseCB.Name = "courseCB";
            this.courseCB.Size = new System.Drawing.Size(265, 28);
            this.courseCB.TabIndex = 62;
            this.courseCB.SelectedIndexChanged += new System.EventHandler(this.courseCB_SelectedIndexChanged);
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadio.Location = new System.Drawing.Point(422, 303);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(85, 24);
            this.femaleRadio.TabIndex = 61;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(289, 303);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(4);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(66, 24);
            this.maleRadio.TabIndex = 60;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 457);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Contact Number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Department:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Course:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Gender:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Full Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Teacher ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(978, 516);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 44);
            this.exitBtn.TabIndex = 53;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(827, 516);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(126, 44);
            this.deleteBtn.TabIndex = 52;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(676, 516);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(132, 44);
            this.editBtn.TabIndex = 51;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBtn.Location = new System.Drawing.Point(1006, 127);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(115, 57);
            this.searchBtn.TabIndex = 50;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(422, 524);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(143, 55);
            this.clearBtn.TabIndex = 49;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(215, 524);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 55);
            this.addBtn.TabIndex = 48;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchTB.Location = new System.Drawing.Point(603, 142);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(381, 22);
            this.searchTB.TabIndex = 47;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // contactTB
            // 
            this.contactTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contactTB.Location = new System.Drawing.Point(289, 457);
            this.contactTB.Margin = new System.Windows.Forms.Padding(4);
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(265, 22);
            this.contactTB.TabIndex = 46;
            this.contactTB.TextChanged += new System.EventHandler(this.contactTB_TextChanged);
            // 
            // fullnameTB
            // 
            this.fullnameTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fullnameTB.Location = new System.Drawing.Point(289, 253);
            this.fullnameTB.Margin = new System.Windows.Forms.Padding(4);
            this.fullnameTB.Name = "fullnameTB";
            this.fullnameTB.Size = new System.Drawing.Size(265, 22);
            this.fullnameTB.TabIndex = 45;
            this.fullnameTB.TextChanged += new System.EventHandler(this.fullnameTB_TextChanged);
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.idTB.Location = new System.Drawing.Point(289, 188);
            this.idTB.Margin = new System.Windows.Forms.Padding(4);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(265, 22);
            this.idTB.TabIndex = 44;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // studentManagementBTN
            // 
            this.studentManagementBTN.AutoSize = true;
            this.studentManagementBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentManagementBTN.Location = new System.Drawing.Point(16, 11);
            this.studentManagementBTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentManagementBTN.Name = "studentManagementBTN";
            this.studentManagementBTN.Size = new System.Drawing.Size(200, 25);
            this.studentManagementBTN.TabIndex = 66;
            this.studentManagementBTN.Text = "Student Management";
            this.studentManagementBTN.Click += new System.EventHandler(this.studentManagementBTN_Click);
            // 
            // courseManagementBTN
            // 
            this.courseManagementBTN.AutoSize = true;
            this.courseManagementBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseManagementBTN.Location = new System.Drawing.Point(236, 11);
            this.courseManagementBTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseManagementBTN.Name = "courseManagementBTN";
            this.courseManagementBTN.Size = new System.Drawing.Size(196, 25);
            this.courseManagementBTN.TabIndex = 67;
            this.courseManagementBTN.Text = "Course Management";
            this.courseManagementBTN.Click += new System.EventHandler(this.label9_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(463, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 25);
            this.exit.TabIndex = 68;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TeacherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 651);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.courseManagementBTN);
            this.Controls.Add(this.studentManagementBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teacherDGV);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.courseCB);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.contactTB);
            this.Controls.Add(this.fullnameTB);
            this.Controls.Add(this.idTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherManagement";
            this.Text = "Teacher Management";
            this.Load += new System.EventHandler(this.TeacherManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView teacherDGV;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.ComboBox courseCB;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.TextBox fullnameTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label studentManagementBTN;
        private System.Windows.Forms.Label courseManagementBTN;
        private System.Windows.Forms.Label exit;
    }
}