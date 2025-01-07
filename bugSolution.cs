public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty with a default value

    public void MyMethod()
    {
        // MyProperty is now initialized, so this line won't throw an exception
        int value = MyProperty * 2;
    }
} 