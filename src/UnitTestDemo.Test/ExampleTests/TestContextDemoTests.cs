namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of the using the TestContext class.</summary>
    [TestClass]
    public class TestContextDemoTests
    {
        public TestContext TestContext { get; set; }

        // Using the TestContext Class will offer many benefits.  One of them is that you can use WriteLine and log actions.
        // Every time a test runs, it’s going to create a new TestContext object or redefine the one property of that
        // class that is of type TestContext.
        // Don’t expect to store any stateful data in the TestContext object in one method and get it within another. It will be overwritten.


        [TestMethod]
        [TestCategory("TestContest Tests")]
        [Description("Demo of using TestName.")]
        [Owner("{developer/team name}")]
        public void IsTrueTest()
        {
            // https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.testcontext?view=visualstudiosdk-2022
            Console.WriteLine($"*** Starting {TestContext.TestName}.");
            Assert.IsTrue(true);
            Console.WriteLine($"*** Ending {TestContext.TestName}.");
        }
    }
}