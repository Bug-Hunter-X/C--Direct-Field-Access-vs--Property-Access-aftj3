public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set
        {
            // Add validation or any other logic here before assigning the value to the field
            if (value >= 0) //Example Validation
            {
                _myField = value;
            }
            else
            {
                //Handle the error appropriately (e.g., throw an exception or set a default value)
                Console.WriteLine("Invalid value for MyProperty. Value must be non-negative.");
                _myField = 0; //Or handle the error in another way
            }
        }
    }

    public void MyMethod()
    {
        //Always use the property for access and modification
        MyProperty = 30; //Using the Property, any validation is executed.
        MyProperty = -5; //Example of validation in action
        Console.WriteLine(MyProperty); //Output: 0. This shows the value is set to 0, not -5.
    }
}