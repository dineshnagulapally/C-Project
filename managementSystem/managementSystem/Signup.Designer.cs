namespace managementSystem
{
    partial class Signup
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
            this.signup_form = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.retype_password_signup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submit_signup = new System.Windows.Forms.Button();
            this.password_signup = new System.Windows.Forms.TextBox();
            this.userName_signup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signup_form.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup_form
            // 
            this.signup_form.Controls.Add(this.panel2);
            this.signup_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup_form.Location = new System.Drawing.Point(0, 0);
            this.signup_form.Name = "signup_form";
            this.signup_form.Size = new System.Drawing.Size(800, 450);
            this.signup_form.TabIndex = 0;
            this.signup_form.Paint += new System.Windows.Forms.PaintEventHandler(this.signup_form_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.retype_password_signup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.submit_signup);
            this.panel2.Controls.Add(this.password_signup);
            this.panel2.Controls.Add(this.userName_signup);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(162, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 329);
            this.panel2.TabIndex = 2;
            // 
            // retype_password_signup
            // 
            this.retype_password_signup.Location = new System.Drawing.Point(214, 190);
            this.retype_password_signup.Name = "retype_password_signup";
            this.retype_password_signup.Size = new System.Drawing.Size(174, 22);
            this.retype_password_signup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // submit_signup
            // 
            this.submit_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_signup.Location = new System.Drawing.Point(214, 243);
            this.submit_signup.Name = "submit_signup";
            this.submit_signup.Size = new System.Drawing.Size(81, 31);
            this.submit_signup.TabIndex = 7;
            this.submit_signup.Text = "Signup";
            this.submit_signup.UseVisualStyleBackColor = true;
            this.submit_signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_signup
            // 
            this.password_signup.Location = new System.Drawing.Point(214, 141);
            this.password_signup.Name = "password_signup";
            this.password_signup.Size = new System.Drawing.Size(174, 22);
            this.password_signup.TabIndex = 4;
            // 
            // userName_signup
            // 
            this.userName_signup.Location = new System.Drawing.Point(214, 90);
            this.userName_signup.Name = "userName_signup";
            this.userName_signup.Size = new System.Drawing.Size(174, 22);
            this.userName_signup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignUp";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signup_form);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.signup_form.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signup_form;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox retype_password_signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit_signup;
        private System.Windows.Forms.TextBox password_signup;
        private System.Windows.Forms.TextBox userName_signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}