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

    private void MyPrivateMethod() { }
    protected void MyProtectedMethod() { }
}

public class DerivedClass : BaseClass
{
    public void MyDerivedMethod()
    {
        // _privateField = 41; // Not OK, this will generate a compile error
        _protectedField = 43; // OK, protected fields can be accessed

        // MyPrivateMethod(); // Not OK, this will generate a compile error
        MyProtectedMethod(); // OK, protected methods can be accessed
    }
}