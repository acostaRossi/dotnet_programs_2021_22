using System.Collections.Generic;

namespace DataBinding
{
    public class Department {
        public List<Student> Students { get; set; }
        public string DepartmentName { get; set; }
        public Department(string departmentName)
        {
            DepartmentName = departmentName;

            Students = new List<Student>();
        }
    }
}
