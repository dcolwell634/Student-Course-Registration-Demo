namespace Student_Course_Registration_Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentLbl = new System.Windows.Forms.Label();
            this.lstBoxRegisteredCourses = new System.Windows.Forms.ListBox();
            this.lstBoxCourses = new System.Windows.Forms.ListBox();
            this.availableCoursesLbl = new System.Windows.Forms.Label();
            this.registeredCoursesLbl = new System.Windows.Forms.Label();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.nonbinaryRadioBtn = new System.Windows.Forms.RadioButton();
            this.txtBoxStudentInfo = new System.Windows.Forms.RichTextBox();
            this.txtBoxCourseInfo = new System.Windows.Forms.RichTextBox();
            this.studentRegLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseInfoLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Location = new System.Drawing.Point(33, 75);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(47, 13);
            this.studentLbl.TabIndex = 1;
            this.studentLbl.Text = "Student:";
            // 
            // lstBoxRegisteredCourses
            // 
            this.lstBoxRegisteredCourses.FormattingEnabled = true;
            this.lstBoxRegisteredCourses.Location = new System.Drawing.Point(594, 123);
            this.lstBoxRegisteredCourses.Name = "lstBoxRegisteredCourses";
            this.lstBoxRegisteredCourses.Size = new System.Drawing.Size(245, 95);
            this.lstBoxRegisteredCourses.TabIndex = 2;
            this.lstBoxRegisteredCourses.SelectedIndexChanged += new System.EventHandler(this.lstBoxRegisteredCourses_SelectedIndexChanged);
            // 
            // lstBoxCourses
            // 
            this.lstBoxCourses.FormattingEnabled = true;
            this.lstBoxCourses.Location = new System.Drawing.Point(302, 123);
            this.lstBoxCourses.Name = "lstBoxCourses";
            this.lstBoxCourses.Size = new System.Drawing.Size(248, 95);
            this.lstBoxCourses.TabIndex = 3;
            this.lstBoxCourses.SelectedIndexChanged += new System.EventHandler(this.lstBoxCourses_SelectedIndexChanged);
            // 
            // availableCoursesLbl
            // 
            this.availableCoursesLbl.AutoSize = true;
            this.availableCoursesLbl.Location = new System.Drawing.Point(299, 107);
            this.availableCoursesLbl.Name = "availableCoursesLbl";
            this.availableCoursesLbl.Size = new System.Drawing.Size(94, 13);
            this.availableCoursesLbl.TabIndex = 4;
            this.availableCoursesLbl.Text = "Available Courses:";
            // 
            // registeredCoursesLbl
            // 
            this.registeredCoursesLbl.AutoSize = true;
            this.registeredCoursesLbl.Location = new System.Drawing.Point(591, 107);
            this.registeredCoursesLbl.Name = "registeredCoursesLbl";
            this.registeredCoursesLbl.Size = new System.Drawing.Size(99, 13);
            this.registeredCoursesLbl.TabIndex = 5;
            this.registeredCoursesLbl.Text = "Registered Courses";
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Enabled = false;
            this.maleRadioBtn.Location = new System.Drawing.Point(162, 91);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.maleRadioBtn.TabIndex = 7;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Enabled = false;
            this.femaleRadioBtn.Location = new System.Drawing.Point(162, 141);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioBtn.TabIndex = 8;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // nonbinaryRadioBtn
            // 
            this.nonbinaryRadioBtn.AutoSize = true;
            this.nonbinaryRadioBtn.Enabled = false;
            this.nonbinaryRadioBtn.Location = new System.Drawing.Point(162, 188);
            this.nonbinaryRadioBtn.Name = "nonbinaryRadioBtn";
            this.nonbinaryRadioBtn.Size = new System.Drawing.Size(77, 17);
            this.nonbinaryRadioBtn.TabIndex = 9;
            this.nonbinaryRadioBtn.TabStop = true;
            this.nonbinaryRadioBtn.Text = "Non-Binary";
            this.nonbinaryRadioBtn.UseVisualStyleBackColor = true;
            // 
            // txtBoxStudentInfo
            // 
            this.txtBoxStudentInfo.Location = new System.Drawing.Point(35, 259);
            this.txtBoxStudentInfo.Name = "txtBoxStudentInfo";
            this.txtBoxStudentInfo.Size = new System.Drawing.Size(196, 144);
            this.txtBoxStudentInfo.TabIndex = 10;
            this.txtBoxStudentInfo.Text = "";
            // 
            // txtBoxCourseInfo
            // 
            this.txtBoxCourseInfo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCourseInfo.Location = new System.Drawing.Point(302, 259);
            this.txtBoxCourseInfo.Name = "txtBoxCourseInfo";
            this.txtBoxCourseInfo.Size = new System.Drawing.Size(537, 144);
            this.txtBoxCourseInfo.TabIndex = 11;
            this.txtBoxCourseInfo.Text = "";
            // 
            // studentRegLbl
            // 
            this.studentRegLbl.AutoSize = true;
            this.studentRegLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentRegLbl.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRegLbl.Location = new System.Drawing.Point(278, 9);
            this.studentRegLbl.Name = "studentRegLbl";
            this.studentRegLbl.Size = new System.Drawing.Size(598, 49);
            this.studentRegLbl.TabIndex = 12;
            this.studentRegLbl.Text = "Student Registration Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Information:";
            // 
            // courseInfoLbl
            // 
            this.courseInfoLbl.AutoSize = true;
            this.courseInfoLbl.Location = new System.Drawing.Point(299, 243);
            this.courseInfoLbl.Name = "courseInfoLbl";
            this.courseInfoLbl.Size = new System.Drawing.Size(98, 13);
            this.courseInfoLbl.TabIndex = 15;
            this.courseInfoLbl.Text = "Course Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Find Student:";
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(84, 18);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(155, 21);
            this.studentsComboBox.TabIndex = 17;
            this.studentsComboBox.SelectedIndexChanged += new System.EventHandler(this.studentsComboBox_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.Location = new System.Drawing.Point(845, 186);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(39, 32);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Location = new System.Drawing.Point(845, 123);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(39, 35);
            this.btnDel.TabIndex = 19;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(556, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 469);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseInfoLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentRegLbl);
            this.Controls.Add(this.txtBoxCourseInfo);
            this.Controls.Add(this.txtBoxStudentInfo);
            this.Controls.Add(this.nonbinaryRadioBtn);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.registeredCoursesLbl);
            this.Controls.Add(this.availableCoursesLbl);
            this.Controls.Add(this.lstBoxCourses);
            this.Controls.Add(this.lstBoxRegisteredCourses);
            this.Controls.Add(this.studentLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label studentLbl;
        private System.Windows.Forms.ListBox lstBoxRegisteredCourses;
        private System.Windows.Forms.ListBox lstBoxCourses;
        private System.Windows.Forms.Label availableCoursesLbl;
        private System.Windows.Forms.Label registeredCoursesLbl;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton nonbinaryRadioBtn;
        private System.Windows.Forms.RichTextBox txtBoxStudentInfo;
        private System.Windows.Forms.RichTextBox txtBoxCourseInfo;
        private System.Windows.Forms.Label studentRegLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseInfoLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
    }
}

