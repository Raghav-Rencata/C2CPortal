namespace C2CPortal.Models
{
    public class StudentDetails
    {
        public int Id { get; set; }
        public int CollegeID { get; set; }
        public string? StudentName { get; set; }
        public string? StudentID { get; set; }         
        public string? EmailID { get; set;}            
        public DateOnly? DOB { get; set; }
        public string? Gender { get; set; }
        public string? TenthPercentage { get; set; }
        public string? InterPercentage { get; set; }
        public string? UGPercentage { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
