namespace taxes.services.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public string Login{ get; set; } use Email as Login?
        public string Salt { get; set; }
    }
}