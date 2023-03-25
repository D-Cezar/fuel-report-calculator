namespace ConsumptionCalculator;

public class Settings
{
    public Company Company { get; set; }
}

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string County { get; set; }
    public string Country { get; set; }
    public string Vat { get; set; }
    public string Reg { get; set; }
}