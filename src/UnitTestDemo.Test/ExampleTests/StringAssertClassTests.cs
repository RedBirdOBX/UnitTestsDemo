using System.Text.RegularExpressions;

namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>StringAssertClass Tests Demo</summary>
    [TestClass]
    public class StringAssertClassTests
    {
        [TestMethod]
        [TestCategory("StringAssert Tests")]
        [Description("A method to test if a specified string contains another string.")]
        [Owner("{developer/team name}")]
        public void ContainsTest()
        {
            string string1 = "Hello World";
            string string2 = "World";
            StringAssert.Contains(string1, string2, "The string is not found.");
        }

        [TestMethod]
        [TestCategory("StringAssert Tests")]
        [Description("A method to test if a specified string starts with a specified string.")]
        [Owner("{developer/team name}")]
        public void StartsWithTest()
        {
            string string1 = "Hello World";
            string string2 = "Hello";
            StringAssert.StartsWith(string1, string2, "The string does not start with your criteria.");
        }

        [TestMethod]
        [TestCategory("StringAssert Tests")]
        [Description("A method to test if a specified string contains all lowercase.")]
        [Owner("{developer/team name}")]
        public void IsAllLowerCaseTest()
        {
            string string1 = "hello world";
            Regex regex = new Regex(@"^([^A-Z])+$");
            StringAssert.Matches(string1, regex, "Is not all lowercase.");
        }

        [TestMethod]
        [TestCategory("StringAssert Tests")]
        [Description("A method to test if a specified string is not all uppercase.")]
        [Owner("{developer/team name}")]
        public void IsNotAllUpperCaseTest()
        {
            string string1 = "HELLO WORLD";
            Regex regex = new Regex(@"^([^A-Z])+$");
            StringAssert.DoesNotMatch(string1, regex, "Is not all uppercase.");
        }
    }
}
