namespace LeaveManagementProject.Data
{
    public abstract class BaseEntity //can be partial
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
