public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Accessing the field directly within the class is fine
        _myField = 10;

        // Accessing the field through the property is also acceptable and generally preferred for better encapsulation.
        MyProperty = 20; 
    }
}