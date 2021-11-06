namespace DataBinding
{
    public class University {
        public University(string univAcronym, string univName, string univAddress)
        {
            UnivAcronym = univAcronym;
            UnivName = univName;
            UnivAddress = univAddress;
        }

        public string UnivAcronym { get; set; }
        public string UnivName { get; set; }
        public string UnivAddress { get; set; }
    }
}
