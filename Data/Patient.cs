namespace MedicalDashboard.Data;

public class Patient
{
    public int Id { get; set; }
    public string Department { get; set; }
    public int? PatientId { get; set; }
    public DateTime InDate { get; set; }
    public string Surname { get; set; }
    public string Firstname { get; set; }
    public string Fathername { get; set; }
    public string Birthdate { get; set; }
    public string Description { get; set; }
    public string Room { get; set; }
    public int? Bed { get; set; }
}
