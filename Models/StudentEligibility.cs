namespace C2CPortal.Models
{
    public class StudentEligibility
    {
        public int Id { get; set; }
        public int RecruitmentID { get; set; }
        public int StudentID { get; set; }
        public bool Round1 { get; set; }
        public bool Round2 { get; set; }
        public bool Round3 { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
