namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of ExceptionAssertClass Tests</summary>
    [TestClass]
    public class ExceptionAssertClassTests
    {
        private Spaceship _spaceship;

        [TestInitialize]
        public void ExceptionAssertClassTestsInit()
        {
            _spaceship = new Spaceship()
            {
                Name = "USS Enterprise",
                Designation = "NCC 1701",
                CrewCapacity = 10,
                PassengerCapacity = 90,
                Classification = ShipClassification.Constitution,
                Id = Guid.NewGuid()
            };

        }


        [TestMethod]
        [TestCategory("ExceptionAssert Demo Tests")]
        [Description("A method to test if a NotImplementedException is properly thrown.")]
        [Owner("{developer/team name}")]
        public void NotImplementedExceptionTest()
        {
            // This test expects the method to return a NotImplementedException response.
            // Since it gets it's expected Exception, it passes the test.
            Assert.ThrowsException<NotImplementedException>(() => _spaceship.GetAutoDestructSequence(), "Method did not throw NotImplementedException.");
        }
    }
}
