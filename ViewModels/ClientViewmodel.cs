namespace UispNet.ViewModels;

public class ClientViewModel
{
    public int? Id { get; set; }
    public string? UserIdent { get; set; }
    public int? ClientType { get; set; }
    public bool? IsLead { get; set; }
    public string? CompanyName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? City { get; set; }
    public double? AddressGpsLat { get; set; }
    public double? AddressGpsLon { get; set; }
}