namespace PersonDevices;

public class Person
{
    private const int MaxNumberOfDevices = 3;
    private string _id;
    private string _fullName;
    private Cellphone?[] _cellphones;

    public Person()
    {
        _id = "invalid id";
        _fullName = "invalid name";
        _cellphones = new Cellphone?[MaxNumberOfDevices];
    }

    public Person(string id, string fullName)
    {
        _id = id;
        _fullName = fullName;
        _cellphones = new Cellphone?[MaxNumberOfDevices];
    }
    
    public string Id {get => _id; set => _id = value; }
    public string FullName {get => _fullName; set => _fullName = value; }

    public void AddCellphone(string imei, string cellphoneNumber)
    {
        for (int i = 0; i < _cellphones.Length; i++)
        {
            if (_cellphones[i] == null)
            {
                _cellphones[i] = new Cellphone() {IMEI = imei, CellphoneNumber = cellphoneNumber };
                break;
            }
        }
    }
    
    public List<string> CellphonesInfo()
    {
        var cellphonesInfo = new List<string>();
        foreach (var cellphone in _cellphones)
        {
            if (cellphone != null)
                cellphonesInfo.Add($"IMEI:{cellphone.IMEI}, CellphoneNumber:{cellphone.CellphoneNumber}");
        }
        return cellphonesInfo;
    }
}