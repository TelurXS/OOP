using System.Diagnostics.Metrics;
using System.IO;

namespace LR2;

public record Address
{
    private const string DEFAULT_COUNTRY = "Ukraine";
    private const string DEFAULT_CITY = "Poltava";
    private const string DEFAULT_POSTAL_CODE = "38000";

    public Address(string street, string city, string postalCode, string country)
    {
        Street = street;
        City = city;
        PostalCode = postalCode;
        Country = country;
    }

    public Address(string street)
    {
        Street = street;
        City = DEFAULT_CITY;
        PostalCode = DEFAULT_POSTAL_CODE;
        Country = DEFAULT_COUNTRY;
    }

    public Address()
    {
        Street = string.Empty;
        City = string.Empty;
        PostalCode = string.Empty;
        Country = string.Empty;
    }

    public string Street { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }
}
