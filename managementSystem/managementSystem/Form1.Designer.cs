namespace managementSystem
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
            this.left_pane = new System.Windows.Forms.Panel();
            this.faculty_details = new System.Windows.Forms.Panel();
            this.enquire_faculty = new System.Windows.Forms.Button();
            this.delete_faculty = new System.Windows.Forms.Button();
            this.add_faculty = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.course_details = new System.Windows.Forms.Panel();
            this.search_course = new System.Windows.Forms.Button();
            this.delete_course = new System.Windows.Forms.Button();
            this.add_course = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.Button();
            this.student_details = new System.Windows.Forms.Panel();
            this.search_student = new System.Windows.Forms.Button();
            this.delete_student = new System.Windows.Forms.Button();
            this.add_student = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.main_area = new System.Windows.Forms.Panel();
            this.left_pane.SuspendLayout();
            this.faculty_details.SuspendLayout();
            this.course_details.SuspendLayout();
            this.student_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_pane
            // 
            this.left_pane.AutoScroll = true;
            this.left_pane.BackColor = System.Drawing.SystemColors.ControlLight;
            this.left_pane.Controls.Add(this.faculty_details);
            this.left_pane.Controls.Add(this.faculty);
            this.left_pane.Controls.Add(this.course_details);
            this.left_pane.Controls.Add(this.course);
            this.left_pane.Controls.Add(this.student_details);
            this.left_pane.Controls.Add(this.student);
            this.left_pane.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_pane.Location = new System.Drawing.Point(0, 0);
            this.left_pane.Name = "left_pane";
            this.left_pane.Size = new System.Drawing.Size(175, 753);
            this.left_pane.TabIndex = 1;
            this.left_pane.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // faculty_details
            // 
            this.faculty_details.Controls.Add(this.enquire_faculty);
            this.faculty_details.Controls.Add(this.delete_faculty);
            this.faculty_details.Controls.Add(this.add_faculty);
            this.faculty_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.faculty_details.Location = new System.Drawing.Point(0, 399);
            this.faculty_details.Name = "faculty_details";
            this.faculty_details.Size = new System.Drawing.Size(175, 129);
            this.faculty_details.TabIndex = 11;
            // 
            // enquire_faculty
            // 
            this.enquire_faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enquire_faculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.enquire_faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enquire_faculty.Location = new System.Drawing.Point(0, 86);
            this.enquire_faculty.Name = "enquire_faculty";
            this.enquire_faculty.Size = new System.Drawing.Size(175, 38);
            this.enquire_faculty.TabIndex = 5;
            this.enquire_faculty.Text = "Enquire Faculty";
            this.enquire_faculty.UseVisualStyleBackColor = true;
            // 
            // delete_faculty
            // 
            this.delete_faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_faculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_faculty.Location = new System.Drawing.Point(0, 44);
            this.delete_faculty.Name = "delete_faculty";
            this.delete_faculty.Size = new System.Drawing.Size(175, 42);
            this.delete_faculty.TabIndex = 4;
            this.delete_faculty.Text = "Delete Faculty";
            this.delete_faculty.UseVisualStyleBackColor = true;
            // 
            // add_faculty
            // 
            this.add_faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_faculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_faculty.Location = new System.Drawing.Point(0, 0);
            this.add_faculty.Name = "add_faculty";
            this.add_faculty.Size = new System.Drawing.Size(175, 44);
            this.add_faculty.TabIndex = 3;
            this.add_faculty.Text = "Add Faculty";
            this.add_faculty.UseVisualStyleBackColor = true;
            // 
            // faculty
            // 
            this.faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.Location = new System.Drawing.Point(0, 353);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(175, 46);
            this.faculty.TabIndex = 10;
            this.faculty.Text = "Faculty";
            this.faculty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.faculty.UseVisualStyleBackColor = true;
            this.faculty.Click += new System.EventHandler(this.faculty_Click);
            // 
            // course_details
            // 
            this.course_details.Controls.Add(this.search_course);
            this.course_details.Controls.Add(this.delete_course);
            this.course_details.Controls.Add(this.add_course);
            this.course_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_details.Location = new System.Drawing.Point(0, 234);
            this.course_details.Name = "course_details";
            this.course_details.Size = new System.Drawing.Size(175, 119);
            this.course_details.TabIndex = 9;
            // 
            // search_course
            // 
            this.search_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_course.Location = new System.Drawing.Point(0, 76);
            this.search_course.Name = "search_course";
            this.search_course.Size = new System.Drawing.Size(175, 40);
            this.search_course.TabIndex = 5;
            this.search_course.Text = "Enquire Course";
            this.search_course.UseVisualStyleBackColor = true;
            // 
            // delete_course
            // 
            this.delete_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_course.Location = new System.Drawing.Point(0, 39);
            this.delete_course.Name = "delete_course";
            this.delete_course.Size = new System.Drawing.Size(175, 37);
            this.delete_course.TabIndex = 4;
            this.delete_course.Text = "Delete Course";
            this.delete_course.UseVisualStyleBackColor = true;
            // 
            // add_course
            // 
            this.add_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_course.Location = new System.Drawing.Point(0, 0);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(175, 39);
            this.add_course.TabIndex = 3;
            this.add_course.Text = "Add Course";
            this.add_course.UseVisualStyleBackColor = true;
            // 
            // course
            // 
            this.course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course.Dock = System.Windows.Forms.DockStyle.Top;
            this.course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.Location = new System.Drawing.Point(0, 187);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(175, 47);
            this.course.TabIndex = 8;
            this.course.Text = "Course";
            this.course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course.UseVisualStyleBackColor = true;
            this.course.Click += new System.EventHandler(this.course_Click);
            // 
            // student_details
            // 
            this.student_details.Controls.Add(this.search_student);
            this.student_details.Controls.Add(this.delete_student);
            this.student_details.Controls.Add(this.add_student);
            this.student_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_details.Location = new System.Drawing.Point(0, 50);
            this.student_details.Name = "student_details";
            this.student_details.Size = new System.Drawing.Size(175, 137);
            this.student_details.TabIndex = 7;
            // 
            // search_student
            // 
            this.search_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_student.Location = new System.Drawing.Point(0, 89);
            this.search_student.Name = "search_student";
            this.search_student.Size = new System.Drawing.Size(175, 45);
            this.search_student.TabIndex = 4;
            this.search_student.Text = "Enquire Student";
            this.search_student.UseVisualStyleBackColor = true;
            // 
            // delete_student
            // 
            this.delete_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_student.Location = new System.Drawing.Point(0, 44);
            this.delete_student.Name = "delete_student";
            this.delete_student.Size = new System.Drawing.Size(175, 45);
            this.delete_student.TabIndex = 3;
            this.delete_student.Text = "Delete Student";
            this.delete_student.UseVisualStyleBackColor = true;
            // 
            // add_student
            // 
            this.add_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_student.Location = new System.Drawing.Point(0, 0);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(175, 44);
            this.add_student.TabIndex = 2;
            this.add_student.Text = "Add Student";
            this.add_student.UseVisualStyleBackColor = true;
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // student
            // 
            this.student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student.Dock = System.Windows.Forms.DockStyle.Top;
            this.student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(0, 0);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(175, 50);
            this.student.TabIndex = 6;
            this.student.Text = "Student";
            this.student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // main_area
            // 
            this.main_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_area.Location = new System.Drawing.Point(175, 0);
            this.main_area.Name = "main_area";
            this.main_area.Size = new System.Drawing.Size(950, 753);
            this.main_area.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1125, 753);
            this.Controls.Add(this.main_area);
            this.Controls.Add(this.left_pane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.left_pane.ResumeLayout(false);
            this.faculty_details.ResumeLayout(false);
            this.course_details.ResumeLayout(false);
            this.student_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel left_pane;
        private System.Windows.Forms.Panel main_area;
        private System.Windows.Forms.Panel student_details;
        private System.Windows.Forms.Button search_student;
        private System.Windows.Forms.Button delete_student;
        private System.Windows.Forms.Button add_student;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Panel faculty_details;
        private System.Windows.Forms.Button enquire_faculty;
        private System.Windows.Forms.Button delete_faculty;
        private System.Windows.Forms.Button add_faculty;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Panel course_details;
        private System.Windows.Forms.Button search_course;
        private System.Windows.Forms.Button delete_course;
        private System.Windows.Forms.Button add_course;
        private System.Windows.Forms.Button course;
    }
}

