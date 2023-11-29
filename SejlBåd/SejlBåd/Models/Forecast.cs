namespace SejlBåd.Models;

public class Forecast
{
    public string Date { get; set; }
    public string Temperature { get; set; }
    public string WindSpeed { get; set; }
    public string WindDirection { get; set; }
    public string Rain { get; set; }

    public Forecast(string date, string temperature, string windSpeed, string windDirection, string rain)
    {
        Date = date;
        Temperature = temperature;
        WindSpeed = windSpeed;
        WindDirection = windDirection;
        Rain = rain;
    }

    public Forecast()
    {
    }
}
