namespace SejlBåd.Models.Dto;

public class DailyDto
{
    public string[] time { get; set; }
    public float[] temperature_2m_min { get; set; }
    public float[] rain_sum { get; set; }
    public float[] wind_speed_10m_max { get; set; }
    public float[] wind_direction_10m_dominant { get; set; }
}
