
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _usa;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

        if (country.ToLower() == "usa" ||
            country.ToLower() == "america" ||
            country.ToLower() == "united states" ||
            country.ToLower() == "united states of america" ||
            country.ToLower() == "us")
        {
            InUsa();
        }
        else
        {
            NotInUsa();
        }
    }

    public void InUsa()
    {
        _usa = true;
    }

    public void NotInUsa()
    {
        _usa = false;
    }

    public bool IfUsa()
    {
        return _usa;
    }

    public string GetAddress()
    {
        return $"Street: {_streetAddress}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}
