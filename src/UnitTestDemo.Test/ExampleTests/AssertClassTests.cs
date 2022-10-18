namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of the different assert tests.</summary>
    [TestClass]
    public class AssertClassTests
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
        [TestCategory("Assert Tests")]
        [Description("Demo of Assert.IsTrue().")]
        [Owner("{developer/team name}")]
        public void IsTrueTest()
        {
            // assert on any variable or expression
            Assert.IsTrue(!string.IsNullOrWhiteSpace(_spaceship.Name), "Name should have a value.");

            // or....
            //bool someCalculation = (1 + 1) == 2;
            //Assert.IsTrue(someCalculation);
        }

        [TestMethod]
        [TestCategory("Assert Tests")]
        [Description("Demo of Assert.IsFalse()")]
        [Owner("{developer/team name}")]
        public void IsFalseTest()
        {
            // we didn't set the HasWarp prop in the constructor so it should be null.
            Assert.IsFalse(_spaceship.HasWarp != null, "Has warp should be defaulted to null.");
        }

        [TestMethod]
        [TestCategory("Assert Tests")]
        [Description("Demo of Assert.AreEqual()")]
        [Owner("{developer/team name}")]
        public void AreEqualTest()
        {
            // You can test primitive value types or reference types.
            Assert.AreEqual(_spaceship.Designation, "NCC 1701", "Designation should match NCC 1701");
        }

        [TestMethod]
        [TestCategory("Assert Tests")]
        [Description("Demo of Assert.AreNotEqual()")]
        [Owner("{developer/team name}")]
        public void AreNotEqualTest()
        {

            // You can test primitive value types or reference types.
            Assert.AreNotEqual(_spaceship.TotalCapacity, 101, "Values are not equal.");

            var spaceship2 = new Spaceship()
            {
                Name = "USS Enterprise",
                Designation = "NCC 1701",
                CrewCapacity = 10,
                PassengerCapacity = 90,
                Classification = ShipClassification.Constitution,
                Id = Guid.NewGuid()
            };

            // diff objs are never equal
            Assert.AreNotEqual(_spaceship, spaceship2, "Objects should not be equal.");
        }

        [TestMethod]
        [TestCategory("Assert Tests")]
        [Description("Demo of Assert.IsInstanceOfType()")]
        [Owner("{developer/team name}")]
        public void IsInstanceOfTypeTest()
        {
            // you can do strings, ints, enums, or concrete ref types like Spaceship.
            Assert.IsInstanceOfType(_spaceship, typeof(Spaceship), "This is not the expected type.");
        }
    }
}