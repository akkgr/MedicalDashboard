namespace MedicalDashboard.Data;

public class Sensor
{
    public Int64 Id { get; set; }
    public string RoomId { get; set; }
    public Int64 BedId { get; set; }
    public DateTime? InDate { get; set; }
    public Int64 BPM { get; set; }
    public Int64 SPO2 { get; set; }
    public Int64 PIPI { get; set; }
}
