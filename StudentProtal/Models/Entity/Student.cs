namespace StudentProtal.Models.Entity
{
    public class Student
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool Subscribe { get; set; }
    }
}
