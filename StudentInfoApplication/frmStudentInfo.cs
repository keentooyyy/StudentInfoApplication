using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{   
    public partial class frmStudentInfo : Form
    {
        private List<StudentInfo> all_student_info = new List<StudentInfo>();
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(StudentIDInputTextBox.Text);
            String first_name = FirstNameInputTextBox.Text;
            String last_name = LastNameInputTextBox.Text;


            StudentInfo studentInfo = new StudentInfo(student_id, first_name, last_name);

            all_student_info.Add(studentInfo);
            for (int i = 0; i < all_student_info.Count; i++)
            {
                if (i == 0)
                {
                    StudentIDOutputTextBox.Text = all_student_info[i].student_id.ToString();
                    FirstNameOutputTextBox.Text = all_student_info[i].student_first_name;
                    LastNameOutputTextBox.Text = all_student_info[i].student_last_name;
                }
                else
                {
                    StudentIDOutputTextBox.AppendText(Environment.NewLine + all_student_info[i].student_id.ToString());
                    FirstNameOutputTextBox.AppendText(Environment.NewLine + all_student_info[i].student_first_name);
                    LastNameOutputTextBox.AppendText(Environment.NewLine + all_student_info[i].student_last_name);
                }
            }
        }
    }
}
