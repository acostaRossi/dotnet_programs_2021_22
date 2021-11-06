namespace DataBinding
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public Student(string studentName, string studentAddress)
        {
            StudentName = studentName;
            StudentAddress = studentAddress;
        }
    }
}
