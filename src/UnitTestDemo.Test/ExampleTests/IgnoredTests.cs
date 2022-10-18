namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of the Ignore attribute.</summary>
    [TestClass]
    public class IgnoredTests
    {

        [Ignore("Test ignored")]
        [TestMethod]
        [TestCategory("Ignored Tests")]
        [Description("Demo of Ignore Attribute.")]
        [Owner("{developer/team name}")]
        public void IsTrueTest()
        {
            // you may have a Test Method that is a WIP or problematic. You can have it ignored.
            int a = 1;
            int b = 2;
            Assert.IsTrue(a == b, "Even though this is not true, it will be ignored.");
        }
    }
}