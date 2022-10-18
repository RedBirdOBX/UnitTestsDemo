namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Inconclusive Tests Demo</summary>
    [TestClass]
    public class InconclusiveTests
    {

        [TestMethod]
        [TestCategory("Inconclusive Tests")]
        [Description("Demo of Inconclusive Assert.")]
        [Owner("{developer/team name}")]
        public void AbsolutelyGonnaTestThis1()
        {
            // your logic here.  It's not to be ignored, rather, it's a WIP or a sketched out method.
            // acts like a 'to do' test.
            Assert.Inconclusive();

        }

        [TestMethod]
        [TestCategory("Inconclusive Tests")]
        [Description("Demo of Inconclusive Assert.")]
        [Owner("{developer/team name}")]
        public void AbsolutelyGonnaTestThis2()
        {
            // your logic here.  It's not to be ignored, rather, it's a WIP or a sketched out method.
            // acts like a 'to do' test.
            Assert.Inconclusive();
        }
    }
}