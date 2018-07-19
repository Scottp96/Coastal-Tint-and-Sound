using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class TestClass
{
    public TestClass() { }
    private string TestPropertyValue;
    public string TestProperty
    {
        get { return TestPropertyValue; }
        set { TestPropertyValue = value; }
    }
}