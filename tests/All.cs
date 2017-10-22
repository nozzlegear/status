using System;
using Xunit;

namespace tests
{
    /// <summary>
    /// These tests are run in C# to make sure the functions feel "right" for both languages. For example, if you use the `function` keyword
    /// in F# to skip writing `match x with`, the method then feels wrong for C# because you have to call it like `method.Invoke(500)` rather 
    /// than `method(500)`. 
    /// </summary>
    public class All
    {
        [Fact(DisplayName = "Creates InternalServerError from 500")]
        public void Test1()
        {
            var code = Status.fromInt(500);

            Assert.Equal(Status.Code.InternalServerError, code);
        }

        [Fact(DisplayName = "Can get a description")]
        public void Test2()
        {
            string expected = "Internal Server Error";
            var code = Status.Code.InternalServerError;

            Assert.Equal(expected, code.Description);
            Assert.Equal(expected, Status.getDescription(code));
        }

        [Fact(DisplayName = "Can get an int from a code")]
        public void Test3()
        {
            int expected = 500;
            var code = Status.Code.InternalServerError;

            Assert.Equal(expected, code.ToInt());
            Assert.Equal(expected, Status.toInt(code));
        }

        [Fact(DisplayName = "Throws an ArgumentOutOfRangeException")]
        public void Test4()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Status.Code.FromInt(700));
            Assert.Throws<ArgumentOutOfRangeException>(() => Status.fromInt(700));
        }
    }
}
