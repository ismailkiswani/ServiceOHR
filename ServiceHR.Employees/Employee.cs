using System;

namespace ServiceHR.Employees
{
    public class Employee
    {
        private string _emp_id;
        private string _emp_name;
        private string _emp_middlename;
        private string _emp_last_name;
        private DateTime _emp_dob;
        private string _emp_mobile;
        private string _emp_jod;

        public string Emp_id { get => _emp_id; set => _emp_id = value; }
        public string Emp_name { get => _emp_name; set => _emp_name = value; }
        public string Emp_middlename { get => _emp_middlename; set => _emp_middlename = value; }
        public string Emp_last_name { get => _emp_last_name; set => _emp_last_name = value; }
        public DateTime Emp_dob { get => _emp_dob; set => _emp_dob = value; }
        public string Emp_mobile { get => _emp_mobile; set => _emp_mobile = value; }
        public string Emp_jod { get => _emp_jod; set => _emp_jod = value; }
    }
}
