namespace LogolendarzFRONT.Models
{
    public class VisitDto
    {
        public int VisitId { get; set; }
        public int SpeechTherId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
    }
}
