namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of ExpectedExceptionClass Tests</summary>
    [TestClass]
    public class ExpectedExceptionClassTests
    {
        private static Spaceship _spaceship;

        [TestInitialize]
        public void AssertClassTestsInit()
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
        [TestCategory("ExpectedExceptionAssert Demo Tests")]
        [Description("A method to test if a NotImplementedException is properly thrown.")]
        [Owner("{developer/team name}")]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetAutoDestructSequence_ThrowsNotImplementedException()
        {
            // This test EXPECTS the method to return a NotImplementedException response.
            // Since it gets it's expected Exception, it passes the test.
            _spaceship.GetAutoDestructSequence();
        }

        [TestMethod]
        [TestCategory("ExpectedExceptionAssert Demo Tests")]
        [Description("A method to test if a NullReferenceException is properly thrown.")]
        [Owner("{developer/team name}")]
        [ExpectedException(typeof(NullReferenceException))]
        public void NonSetHasWarp_ThrowsNullReferenceException()
        {
            // This test EXPECTS the method to return a NullReferenceException response.
            // Since it gets it's expected Exception, it passes the test.
            var spaceship1 = new Spaceship();
            spaceship1 = null;
            if (spaceship1.PassengerCapacity > 0)
            {
                Console.WriteLine($"spaceship1.PassengerCapacity: {spaceship1.PassengerCapacity}.");
            }
        }
    }
}
