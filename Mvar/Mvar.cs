using System.Globalization;
using System.Collections;
using System.Runtime.CompilerServices;

[CollectionBuilder(typeof(Mvar), nameof(CreateCollection))]
public class Mvar : IEnumerable<Mvar>
{   
    /*
    Mvar stands for "Maximus Variable" which means that it is the Greatest Variable.

    Mvar is a mutable variable in c# capable of being an int, double, string, boolean, 
    or a list or 2d nested list of any of the before mentioned data types.

    Mvar automatically detects if a string which is input is an int, double, or boolean
    along with taking any valid data type as an input.

    Mvar has a constructor that can fill it with any one valid data type.

    Methods:
        Val()      - the current value of the Mvar.
        Set()      - changes the value of the Mvar to any valid data type.
        Type()     - returns a string that expalins the current type of data in the Mvar.
        Length()   - returns an int of how long the Mvar is if it is a string or list, otherwise it returns 0.
        Count()    - returns an int of how many items are in Mvar, if Mvar is not a list 1 will be returned.
        AsString() - returns a string showing the data inside Mvar.
        Add()      - adds the input value to the Mvar if they are compatable in a way that varies depending on the current type of the Mvar.
    */

    int _dataType;

    int _int = 0;
    double _double = 0;
    String _string = "";
    Boolean _boolean = false;
    List<Mvar> _mvarList = new List<Mvar>();

    public Mvar()
    {}
    public Mvar(dynamic data)
    {
        Set(data);
    }
    public Mvar(ReadOnlySpan<Mvar> data)
    {
        Set(new List<Mvar>(data.ToArray()));
    }
    public static Mvar CreateCollection(ReadOnlySpan<Mvar> data)
    {
        return new Mvar(data);
    }

    public static implicit operator Mvar(int data) => new Mvar(data);
    public static implicit operator Mvar(double data) => new Mvar(data);
    public static implicit operator Mvar(string data) => new Mvar(data);
    public static implicit operator Mvar(bool data) => new Mvar(data);

    public IEnumerator<Mvar> GetEnumerator() => _mvarList.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public dynamic Val()
    {
        switch (_dataType)
        {
            case 0:
                return _int;
            case 1:
                return _double;
            case 2:
                return _string;
            case 3:
                return _boolean;
            case 4:
                return _mvarList;
            default:
                return "ERROR";
        }
    }

    public void Set(String data)
    {
        string trimmedData = data?.Trim();

        if (int.TryParse(trimmedData, NumberStyles.Integer, CultureInfo.InvariantCulture, out int intValue))
        {
            _dataType = 0;
            _int = intValue;
        }
        else if (double.TryParse(trimmedData, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out double doubleValue))
        {
            _dataType = 1;
            _double = doubleValue;
        }
        else if (Boolean.TryParse(trimmedData, out bool boolValue))
        {
            _dataType = 3;
            _boolean = boolValue;
        }
        else
        {
            _dataType = 2;
            _string = data;
        }
    }
    public void Set(int data)
    {
        _dataType = 0;
        _int = data;
    }
    public void Set(double data)
    {
        _dataType = 1;
        _double = data;
    }
    public void Set(Boolean data)
    {
        _dataType = 3;
        _boolean = data;
    }
    public void Set(List<Mvar> data)
    {
        _dataType = 4;
        _mvarList = data;
    }
    public void Set(List<int> data)
    {
        _dataType = 4;
        _mvarList.Clear();
        foreach (int i in data)
        {
            _mvarList.Add(new Mvar(i));
        }
    }
    public void Set(List<double> data)
    {
        _dataType = 4;
        _mvarList.Clear();
        foreach (double d in data)
        {
            _mvarList.Add(new Mvar(d));
        }
    }
    public void Set(List<String> data)
    {
        _dataType = 4;
        _mvarList.Clear();
        foreach (String s in data)
        {
            _mvarList.Add(new Mvar(s));
        }
    }
    public void Set(List<Boolean> data)
    {
        _dataType = 4;
        _mvarList.Clear();
        foreach (Boolean b in data)
        {
            _mvarList.Add(new Mvar(b));
        }
    }

    public string Type()
    {
        switch(_dataType)
        {
            case 0:
                return "int";
            case 1:
                return "double";
            case 2:
                return "string";
            case 3:
                return "boolean";
            case 4:
                return "list of ints";
            case 5:
                return "list of Mvars";
            default:
                return "null";
        }
    }

    public int Length()
    {
        switch(_dataType)
        {
            case 2:
                return _string.Length;
            case 4:
                return _mvarList.Count;
            default:
                return 0;
        }
    }

    public int Count()
    {
        int count = 0;
        if (_dataType == 4)
        {
            foreach (Mvar mvar in _mvarList)
            {
                count += mvar.Count();
            }
        }
        else
        {
            count += 1;
        }
        return count;
    }

    public String AsString()
    {   
        String str = "";

        void CommaLists()
        {
            if (str[^1] != '(')
            {
                str += ", ";
            }
        }

        if (_dataType <= 3)
        {
            str = $"{Val()}";
        }
        else if (_dataType == 4)
        {
            str = "(";
            foreach (Mvar m in _mvarList)
            {   
                CommaLists();
                str += $"{m.AsString()}";
            }
            str += ")";
        }

        return str;
    }

    public void Add(string adder)
    {
        string trimmedAdder = adder?.Trim();

        if (_dataType == 0)
        {
            if (int.TryParse(trimmedAdder, NumberStyles.Integer, CultureInfo.InvariantCulture, out int adderValue))
            {
                _int += adderValue;
            }
            else
            {
                _dataType = 3;
                _string = $"{_int}{adder}";
            }
        }
        else if (_dataType == 1)
        {
            if (double.TryParse(trimmedAdder, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out double adderValue))
            {
                _double += adderValue;
            }
            else
            {
                _dataType = 3;
                _string = $"{_double}{adder}";
            }
        }
        else if (_dataType == 2)
        {
            _string += adder;
        }
        else if (_dataType == 3)
        {
            if (Boolean.TryParse(trimmedAdder, out bool adderValue))
            {
                if (adderValue) { _boolean = true;}
            }
            else
            {
                _dataType = 3;
                _string = $"{_boolean}{adder}";
            }
        }
        else if (_dataType == 4)
        {
            Mvar var = new Mvar(adder);
            _mvarList.Add(var);
        }
        else
        {
            Set(adder);
        }
    }
    public void Add(int adder)
    {
        if (_dataType == 0)
        {
            _int += adder;
        }
        else if (_dataType == 1)
        {
            _double += adder;
        }
        else if (_dataType == 2)
        {
            _string += $"{adder}";
        }
        else if (_dataType == 3)
        {}
        else if (_dataType == 4)
        {
            _mvarList.Add(new Mvar(adder));
        }
        else
        {
            Set(adder);
        }
    }
    public void Add(double adder)
    {
        if (_dataType == 0)
        {   
            _dataType = 1;
            _double = _int + adder;
        }
        else if (_dataType == 1)
        {
            _double += adder;
        }
        else if (_dataType == 2)
        {
            _string += $"{adder}";
        }
        else if (_dataType == 3)
        {}
        else if (_dataType == 4)
        {
            _mvarList.Add(new Mvar(adder));
        }
        else
        {
            Set(adder);
        }
    }
    public void Add(Boolean adder)
    {   
        if (_dataType == 0)
        {}
        else if (_dataType == 1)
        {}
        else if (_dataType == 2)
        {
            _string += $"{adder}";
        }
        else if (_dataType == 3)
        {
            if (adder) { _boolean = true;}
        }
        else if (_dataType == 4)
        {
            _mvarList.Add(new Mvar(adder));
        }
        else
        {
            Set(adder);
        }
    }
    public void Add(List<Mvar> adder)
    {   
        if (_dataType <= 3)
        {   
            _mvarList = [new Mvar(Val())];
            _dataType = 4;
            foreach (Mvar a in adder)
            {
                _mvarList.Add(a);
            }
        }
        else if (_dataType == 4)
        {   
            foreach (Mvar a in adder)
            {
                _mvarList.Add(a);
            }
        }
    }
}