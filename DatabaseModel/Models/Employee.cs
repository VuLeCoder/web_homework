namespace DatabaseModel.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string fullName { get; set; } = "";
        public string gender { get; set; } = "";
        public string phone { get; set; } = "";
        public string email { get; set; } = "";
        public int salary { get; set; }
        public int status { get; set; }
    }
}
