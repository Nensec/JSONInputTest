using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class TestModel
    {
        public string TestStringKey { get; set; }
        public decimal? TestNumericKey { get; set; }
        public List<TestModel> TestListKey { get; set; }
        public bool? TestBooleanKey { get; set; }
        public TestEnum? TestEnum { get; set; }
    }

    public enum TestEnum
    {
        TestValue1,
        TestValue2
    }
}