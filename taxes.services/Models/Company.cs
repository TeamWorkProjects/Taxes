namespace taxes.services.Models
{
    public abstract class Company : BaseEntity
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string NIP { get; set; }
    }
}