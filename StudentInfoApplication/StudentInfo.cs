using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    internal class StudentInfo
    {
        public int student_id;
        private String studentFName;
        private String studentLName;
        public String student_first_name
        {
            get { return studentFName; }
        }
        public String student_last_name
        {
            get { return studentLName; }
        }
        public StudentInfo(int id, String first_name, String last_name)
        {
            this.student_id = id;
            this.studentFName = first_name;
            this.studentLName = last_name;
        }
        public StudentInfo()
        {
            this.student_id = 0;
            this.studentFName = "Enter First Name";
            this.studentLName = "Enter Last Name";
        }
        
    }
}
