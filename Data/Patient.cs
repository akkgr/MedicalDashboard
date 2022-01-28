namespace MedicalDashboard.Data;

public class Patient
{
    public Int64 Id { get; set; }
    public int RoomId { get; set; }
    public string RoomName { get; set; }
    public int BedId { get; set; }
    public string PatName { get; set; }
    public string Sex { get; set; }
    public DateTime? InDate { get; set; }
}
