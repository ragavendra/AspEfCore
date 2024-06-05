namespace TodoApi.Models;

public class StopItem
{
    public long Id { get; set; }
    public long Code { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Latitude { get; set; }
    public double Longiitude { get; set; }
    public char? ZoneId { get; set; }
    public Uri? Url { get; set; }
    public int? LocationType { get; set; }
    public int? ParentStation { get; set; }
}
