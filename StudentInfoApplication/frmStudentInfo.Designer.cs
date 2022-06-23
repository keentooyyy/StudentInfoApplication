namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentIDInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameInputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentIDOutputTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameOutputTextBox = new System.Windows.Forms.TextBox();
            this.LastNameOutputTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID *";
            // 
            // StudentIDInputTextBox
            // 
            this.StudentIDInputTextBox.Location = new System.Drawing.Point(16, 34);
            this.StudentIDInputTextBox.Name = "StudentIDInputTextBox";
            this.StudentIDInputTextBox.Size = new System.Drawing.Size(172, 26);
            this.StudentIDInputTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name *";
            // 
            // LastNameInputTextBox
            // 
            this.LastNameInputTextBox.Location = new System.Drawing.Point(197, 34);
            this.LastNameInputTextBox.Name = "LastNameInputTextBox";
            this.LastNameInputTextBox.Size = new System.Drawing.Size(172, 26);
            this.LastNameInputTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name *";
            // 
            // FirstNameInputTextBox
            // 
            this.FirstNameInputTextBox.Location = new System.Drawing.Point(378, 34);
            this.FirstNameInputTextBox.Name = "FirstNameInputTextBox";
            this.FirstNameInputTextBox.Size = new System.Drawing.Size(172, 26);
            this.FirstNameInputTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student ID List";
            // 
            // StudentIDOutputTextBox
            // 
            this.StudentIDOutputTextBox.Location = new System.Drawing.Point(19, 147);
            this.StudentIDOutputTextBox.Multiline = true;
            this.StudentIDOutputTextBox.Name = "StudentIDOutputTextBox";
            this.StudentIDOutputTextBox.Size = new System.Drawing.Size(169, 250);
            this.StudentIDOutputTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name List";
            // 
            // FirstNameOutputTextBox
            // 
            this.FirstNameOutputTextBox.Location = new System.Drawing.Point(197, 147);
            this.FirstNameOutputTextBox.Multiline = true;
            this.FirstNameOutputTextBox.Name = "FirstNameOutputTextBox";
            this.FirstNameOutputTextBox.Size = new System.Drawing.Size(169, 250);
            this.FirstNameOutputTextBox.TabIndex = 9;
            // 
            // LastNameOutputTextBox
            // 
            this.LastNameOutputTextBox.Location = new System.Drawing.Point(378, 147);
            this.LastNameOutputTextBox.Multiline = true;
            this.LastNameOutputTextBox.Name = "LastNameOutputTextBox";
            this.LastNameOutputTextBox.Size = new System.Drawing.Size(169, 250);
            this.LastNameOutputTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name List";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(459, 67);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(87, 36);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 436);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastNameOutputTextBox);
            this.Controls.Add(this.FirstNameOutputTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentIDOutputTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameInputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameInputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentIDInputTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentInfo";
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentIDInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameInputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentIDOutputTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameOutputTextBox;
        private System.Windows.Forms.TextBox LastNameOutputTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SubmitButton;
    }
}

