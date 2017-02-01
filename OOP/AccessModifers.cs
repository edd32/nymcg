public class AccessibilityClass
{
    private string _myField;

    public string MyProperty
    {
        get { return _myField;  }
        set{ _myField = value;  }
    }
}

public class BaseClass
{
    private int _privateField = 40;
    protected int _protectedField = 40;

    private void PrivateMethod() { }
    protected void ProtectedMethod() { }
}

public class DerivedClass : BaseClass
{
    public void DerivedMethod()
    {
        // _privateField = 41; // Not OK, compile error
        _protectedField = 43; // OK, protected fields can be accessed

        // PrivateMethod(); // Not OK, compile error
        ProtectedMethod(); // OK, protected methods can be accessed
    }
}