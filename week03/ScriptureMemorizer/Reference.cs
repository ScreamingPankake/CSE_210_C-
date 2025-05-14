

public class Reference
{

    public static string GetReference(int index)
    {
        string _reference = "";
        if(index == 0)
        {
            _reference = "2 Nephi 2:25 ";
        }
        else if(index == 1)
        {
            _reference = "Alma 40:8 ";
        }
        else if(index == 2)
        {
            _reference = "Alma 53:20-21 ";
        }
        else if(index == 3)
        {
            _reference = "Mosiah 4:26 ";
        }
        else if(index == 4)
        {
            _reference = "Mosiah 16:7-9 ";
        }
        else if(index == 5)
        {
            _reference = "Mosiah 27:31 ";
        }
        return _reference;
    }
}