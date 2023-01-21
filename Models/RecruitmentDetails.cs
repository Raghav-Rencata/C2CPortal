namespace C2CPortal.Models
{
    public class RecruitmentDetails
    {
        public int Id { get; set; }
        public int CompanyID { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public string? SkillsSet { get; set; }
        public string? CGPARequired { get; set; }
        public string? Location { get; set; }
        public DateTime? InterviewDateTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
