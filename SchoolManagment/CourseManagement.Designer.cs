namespace SchoolManagment
{
    partial class CourseManagement
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
            this.label7 = new System.Windows.Forms.Label();
            this.courseDGV = new System.Windows.Forms.DataGridView();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseExitBtn = new System.Windows.Forms.Button();
            this.courseDeleteBtn = new System.Windows.Forms.Button();
            this.courseEditBtn = new System.Windows.Forms.Button();
            this.courseSearchBtn = new System.Windows.Forms.Button();
            this.courseClearBtn = new System.Windows.Forms.Button();
            this.courseAddBtn = new System.Windows.Forms.Button();
            this.courseSearchTB = new System.Windows.Forms.TextBox();
            this.courseIdTB = new System.Windows.Forms.TextBox();
            this.studentManagementBTN = new System.Windows.Forms.Label();
            this.coursManagentBTN = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.coursenameCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(445, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 32);
            this.label7.TabIndex = 81;
            this.label7.Text = "Course Managment";
            // 
            // courseDGV
            // 
            this.courseDGV.AllowUserToOrderColumns = true;
            this.courseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDGV.Location = new System.Drawing.Point(599, 204);
            this.courseDGV.Margin = new System.Windows.Forms.Padding(4);
            this.courseDGV.Name = "courseDGV";
            this.courseDGV.RowHeadersWidth = 51;
            this.courseDGV.Size = new System.Drawing.Size(504, 325);
            this.courseDGV.TabIndex = 80;
            // 
            // categoryCB
            // 
            this.categoryCB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "Information Technology",
            "Accounting",
            "Engineering",
            "Business"});
            this.categoryCB.Location = new System.Drawing.Point(276, 295);
            this.categoryCB.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(265, 24);
            this.categoryCB.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Course ID:";
            // 
            // courseExitBtn
            // 
            this.courseExitBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.courseExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseExitBtn.Location = new System.Drawing.Point(977, 555);
            this.courseExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseExitBtn.Name = "courseExitBtn";
            this.courseExitBtn.Size = new System.Drawing.Size(105, 48);
            this.courseExitBtn.TabIndex = 75;
            this.courseExitBtn.Text = "EXIT";
            this.courseExitBtn.UseVisualStyleBackColor = false;
            this.courseExitBtn.Click += new System.EventHandler(this.courseExitBtn_Click);
            // 
            // courseDeleteBtn
            // 
            this.courseDeleteBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.courseDeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseDeleteBtn.Location = new System.Drawing.Point(809, 555);
            this.courseDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseDeleteBtn.Name = "courseDeleteBtn";
            this.courseDeleteBtn.Size = new System.Drawing.Size(127, 48);
            this.courseDeleteBtn.TabIndex = 74;
            this.courseDeleteBtn.Text = "DELETE";
            this.courseDeleteBtn.UseVisualStyleBackColor = false;
            this.courseDeleteBtn.Click += new System.EventHandler(this.courseDeleteBtn_Click);
            // 
            // courseEditBtn
            // 
            this.courseEditBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.courseEditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseEditBtn.Location = new System.Drawing.Point(652, 555);
            this.courseEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseEditBtn.Name = "courseEditBtn";
            this.courseEditBtn.Size = new System.Drawing.Size(122, 48);
            this.courseEditBtn.TabIndex = 73;
            this.courseEditBtn.Text = "EDIT";
            this.courseEditBtn.UseVisualStyleBackColor = false;
            this.courseEditBtn.Click += new System.EventHandler(this.courseEditBtn_Click);
            // 
            // courseSearchBtn
            // 
            this.courseSearchBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.courseSearchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseSearchBtn.Location = new System.Drawing.Point(956, 151);
            this.courseSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseSearchBtn.Name = "courseSearchBtn";
            this.courseSearchBtn.Size = new System.Drawing.Size(147, 45);
            this.courseSearchBtn.TabIndex = 72;
            this.courseSearchBtn.Text = "SEARCH";
            this.courseSearchBtn.UseVisualStyleBackColor = false;
            this.courseSearchBtn.Click += new System.EventHandler(this.courseSearchBtn_Click);
            // 
            // courseClearBtn
            // 
            this.courseClearBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.courseClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseClearBtn.Location = new System.Drawing.Point(408, 498);
            this.courseClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseClearBtn.Name = "courseClearBtn";
            this.courseClearBtn.Size = new System.Drawing.Size(133, 67);
            this.courseClearBtn.TabIndex = 71;
            this.courseClearBtn.Text = "CLEAR";
            this.courseClearBtn.UseVisualStyleBackColor = false;
            this.courseClearBtn.Click += new System.EventHandler(this.courseClearBtn_Click);
            // 
            // courseAddBtn
            // 
            this.courseAddBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.courseAddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseAddBtn.Location = new System.Drawing.Point(217, 498);
            this.courseAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.courseAddBtn.Name = "courseAddBtn";
            this.courseAddBtn.Size = new System.Drawing.Size(138, 67);
            this.courseAddBtn.TabIndex = 70;
            this.courseAddBtn.Text = "ADD";
            this.courseAddBtn.UseVisualStyleBackColor = false;
            this.courseAddBtn.Click += new System.EventHandler(this.courseAddBtn_Click);
            // 
            // courseSearchTB
            // 
            this.courseSearchTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.courseSearchTB.Location = new System.Drawing.Point(599, 157);
            this.courseSearchTB.Margin = new System.Windows.Forms.Padding(4);
            this.courseSearchTB.Name = "courseSearchTB";
            this.courseSearchTB.Size = new System.Drawing.Size(349, 22);
            this.courseSearchTB.TabIndex = 69;
            // 
            // courseIdTB
            // 
            this.courseIdTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.courseIdTB.Location = new System.Drawing.Point(276, 176);
            this.courseIdTB.Margin = new System.Windows.Forms.Padding(4);
            this.courseIdTB.Name = "courseIdTB";
            this.courseIdTB.Size = new System.Drawing.Size(265, 22);
            this.courseIdTB.TabIndex = 66;
            // 
            // studentManagementBTN
            // 
            this.studentManagementBTN.AutoSize = true;
            this.studentManagementBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentManagementBTN.Location = new System.Drawing.Point(13, 9);
            this.studentManagementBTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentManagementBTN.Name = "studentManagementBTN";
            this.studentManagementBTN.Size = new System.Drawing.Size(200, 25);
            this.studentManagementBTN.TabIndex = 82;
            this.studentManagementBTN.Text = "Student Management";
            this.studentManagementBTN.Click += new System.EventHandler(this.studentManagementBTN_Click);
            // 
            // coursManagentBTN
            // 
            this.coursManagentBTN.AutoSize = true;
            this.coursManagentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursManagentBTN.Location = new System.Drawing.Point(241, 9);
            this.coursManagentBTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coursManagentBTN.Name = "coursManagentBTN";
            this.coursManagentBTN.Size = new System.Drawing.Size(196, 25);
            this.coursManagentBTN.TabIndex = 83;
            this.coursManagentBTN.Text = "Course Management";
            this.coursManagentBTN.Click += new System.EventHandler(this.coursManagentBTN_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(471, 9);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 25);
            this.exit.TabIndex = 84;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // coursenameCB
            // 
            this.coursenameCB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.coursenameCB.FormattingEnabled = true;
            this.coursenameCB.Items.AddRange(new object[] {
            "Software Development",
            "Project Management",
            "Business Studies",
            "Physics",
            "Programming Foundation"});
            this.coursenameCB.Location = new System.Drawing.Point(276, 236);
            this.coursenameCB.Margin = new System.Windows.Forms.Padding(4);
            this.coursenameCB.Name = "coursenameCB";
            this.coursenameCB.Size = new System.Drawing.Size(265, 24);
            this.coursenameCB.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 87;
            this.label5.Text = "Description:";
            // 
            // descriptionTB
            // 
            this.descriptionTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.descriptionTB.Location = new System.Drawing.Point(276, 368);
            this.descriptionTB.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(265, 85);
            this.descriptionTB.TabIndex = 88;
            this.descriptionTB.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 676);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coursenameCB);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.coursManagentBTN);
            this.Controls.Add(this.studentManagementBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.courseDGV);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseExitBtn);
            this.Controls.Add(this.courseDeleteBtn);
            this.Controls.Add(this.courseEditBtn);
            this.Controls.Add(this.courseSearchBtn);
            this.Controls.Add(this.courseClearBtn);
            this.Controls.Add(this.courseAddBtn);
            this.Controls.Add(this.courseSearchTB);
            this.Controls.Add(this.courseIdTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CourseManagement";
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.CourseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView courseDGV;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button courseExitBtn;
        private System.Windows.Forms.Button courseDeleteBtn;
        private System.Windows.Forms.Button courseEditBtn;
        private System.Windows.Forms.Button courseSearchBtn;
        private System.Windows.Forms.Button courseClearBtn;
        private System.Windows.Forms.Button courseAddBtn;
        private System.Windows.Forms.TextBox courseSearchTB;
        private System.Windows.Forms.TextBox courseIdTB;
        private System.Windows.Forms.Label studentManagementBTN;
        private System.Windows.Forms.Label coursManagentBTN;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.ComboBox coursenameCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descriptionTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}