namespace C2CPortal.Models
{
    public class RecruitmentPost
    {
        public int Id { get; set; }
        public int CollegeId { get; set; }
        public int RecruitmentID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
