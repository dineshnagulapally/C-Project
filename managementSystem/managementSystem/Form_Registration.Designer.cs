namespace managementSystem
{
    partial class Form_Registration
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
            this.student_grid = new System.Windows.Forms.DataGridView();
            this.reg_student = new System.Windows.Forms.Panel();
            this.clear_reg = new System.Windows.Forms.Button();
            this.submit_reg = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dateOfBorn = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.form_label = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_grid)).BeginInit();
            this.reg_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_grid
            // 
            this.student_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_grid.Location = new System.Drawing.Point(0, 0);
            this.student_grid.Name = "student_grid";
            this.student_grid.RowHeadersWidth = 51;
            this.student_grid.RowTemplate.Height = 24;
            this.student_grid.Size = new System.Drawing.Size(1026, 228);
            this.student_grid.TabIndex = 0;
            this.student_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_grid_CellClick);
            this.student_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_grid_CellContentClick);
            // 
            // reg_student
            // 
            this.reg_student.Controls.Add(this.id);
            this.reg_student.Controls.Add(this.form_label);
            this.reg_student.Controls.Add(this.clear_reg);
            this.reg_student.Controls.Add(this.submit_reg);
            this.reg_student.Controls.Add(this.phone);
            this.reg_student.Controls.Add(this.label5);
            this.reg_student.Controls.Add(this.female);
            this.reg_student.Controls.Add(this.male);
            this.reg_student.Controls.Add(this.label4);
            this.reg_student.Controls.Add(this.dateOfBirth);
            this.reg_student.Controls.Add(this.dateOfBorn);
            this.reg_student.Controls.Add(this.lastName);
            this.reg_student.Controls.Add(this.firstName);
            this.reg_student.Controls.Add(this.label2);
            this.reg_student.Controls.Add(this.label1);
            this.reg_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.reg_student.Location = new System.Drawing.Point(0, 228);
            this.reg_student.Name = "reg_student";
            this.reg_student.Size = new System.Drawing.Size(1026, 524);
            this.reg_student.TabIndex = 1;
            // 
            // clear_reg
            // 
            this.clear_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_reg.Location = new System.Drawing.Point(479, 268);
            this.clear_reg.Name = "clear_reg";
            this.clear_reg.Size = new System.Drawing.Size(92, 29);
            this.clear_reg.TabIndex = 12;
            this.clear_reg.Text = "Clear";
            this.clear_reg.UseVisualStyleBackColor = true;
            this.clear_reg.Click += new System.EventHandler(this.clear_reg_Click);
            // 
            // submit_reg
            // 
            this.submit_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_reg.Location = new System.Drawing.Point(356, 268);
            this.submit_reg.Name = "submit_reg";
            this.submit_reg.Size = new System.Drawing.Size(92, 29);
            this.submit_reg.TabIndex = 11;
            this.submit_reg.Text = "Submit";
            this.submit_reg.UseVisualStyleBackColor = true;
            this.submit_reg.Click += new System.EventHandler(this.submit_reg_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(144, 201);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(160, 22);
            this.phone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone : ";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(680, 201);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(80, 20);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(579, 201);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(62, 20);
            this.male.TabIndex = 7;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender : ";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(579, 148);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(181, 22);
            this.dateOfBirth.TabIndex = 5;
            // 
            // dateOfBorn
            // 
            this.dateOfBorn.AutoSize = true;
            this.dateOfBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBorn.Location = new System.Drawing.Point(423, 154);
            this.dateOfBorn.Name = "dateOfBorn";
            this.dateOfBorn.Size = new System.Drawing.Size(98, 16);
            this.dateOfBorn.TabIndex = 4;
            this.dateOfBorn.Text = "DateOfBirth : ";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(144, 151);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(160, 22);
            this.lastName.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(144, 94);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(160, 22);
            this.firstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName : ";
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_label.Location = new System.Drawing.Point(389, 28);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(132, 25);
            this.form_label.TabIndex = 13;
            this.form_label.Text = "Add Student";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(579, 70);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(44, 16);
            this.id.TabIndex = 14;
            this.id.Text = "label3";
            this.id.Visible = false;
            // 
            // Form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 584);
            this.Controls.Add(this.reg_student);
            this.Controls.Add(this.student_grid);
            this.Name = "Form_Registration";
            this.Text = "Form_Registration";
            this.Load += new System.EventHandler(this.Form_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_grid)).EndInit();
            this.reg_student.ResumeLayout(false);
            this.reg_student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView student_grid;
        private System.Windows.Forms.Panel reg_student;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label dateOfBorn;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_reg;
        private System.Windows.Forms.Button submit_reg;
        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.Label id;
    }
}