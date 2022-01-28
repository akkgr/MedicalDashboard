namespace MedicalDashboard.Data;

public class Sensor
{
    public Int64 Id { get; set; }
    public int RoomId { get; set; }
    public int BedId { get; set; }
    public DateTime? InDate { get; set; }
    public int BPM { get; set; }
    public int SPO2 { get; set; }
    public int PIPI { get; set; }
}
