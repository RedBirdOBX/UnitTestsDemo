namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demonstrates the life cycle of the Test Class.</summary>
    [TestClass]
    public class LifeCycleTests
    {
        private bool _isTrue = false;
        private static string _secretOfLife = string.Empty;


        [ClassInitialize]
        public static void LifeCycleClassInit(TestContext context)
        {
            // this executes as the class is initialized.
            Console.WriteLine($"Class Init....");

            // this could be an expensive process like a disk read from a lrg file...
            // ...so let's do it only once and set it as a field.
            _secretOfLife = "What is 42?";
        }

        [TestInitialize]
        public void LifeCycleInit()
        {
            // this executes before the test.
            _isTrue = true;
            Console.WriteLine($"     LifeCycleInit: _isTrue = {_isTrue}");
        }

        [TestMethod]
        [TestCategory("LifeCycle Tests")]
        [Description("TestMethod.")]
        public void TestMethod()
        {
            Console.WriteLine($"             Running TestMethod");
            Assert.IsTrue(_isTrue, "Is not true.");
            Assert.IsTrue(_secretOfLife.Length > 0, "Secret has no length.");
        }

        [TestCleanup]
        public void LifeCycleCleanUp()
        {
            // this executes after the test.
            _isTrue = false;
            Console.WriteLine($"     LifeCycleCleanUp: _isTrue = {_isTrue}");
        }

        [ClassCleanup]
        public static void LifeCycleClassCleanUp()
        {
            // this executes as the class is disposed of.
            Console.WriteLine($"Class CleanUp....");
        }
    }
}
