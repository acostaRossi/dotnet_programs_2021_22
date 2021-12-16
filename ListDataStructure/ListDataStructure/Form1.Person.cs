namespace ListDataStructure
{
    public partial class Form1
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Print {
                get {
                    return $"{Name} {Age}";
                }
            }
        }
    }
}
