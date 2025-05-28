

class Adress
{


    public static string Combine_Full_Adress(string street, string city, string country)
    {
        return $"{street}, {city}, {country}";
    }

    public static bool Check_Country(string country)
    {
        if (country.ToLower() == "america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}