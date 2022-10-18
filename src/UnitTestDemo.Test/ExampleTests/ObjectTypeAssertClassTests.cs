namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>ObjectAssert Demo Tests</summary>
    [TestClass]
    public class ObjectTypeAssertClassTests
    {

        private static Spaceship _spaceship1;
        private static Spaceship _spaceship2;


        [TestInitialize]
        public void ObjectTypeAssertClassTestsInit()
        {
            _spaceship1 = new Spaceship()
            {
                Name = "USS Enterprise",
                Designation = "NCC 1701",
                CrewCapacity = 10,
                PassengerCapacity = 90,
                Classification = ShipClassification.Constitution,
                Id = Guid.NewGuid()
            };

            _spaceship2 = new Spaceship()
            {
                Name = "USS Enterprise D",
                Designation = "NCC 1701 D",
                CrewCapacity = 100,
                PassengerCapacity = 900,
                Classification = ShipClassification.Galaxy,
                Id = Guid.NewGuid()
            };
        }


        [TestMethod]
        [TestCategory("ObjectAssert Tests")]
        [Description("Demo of the Assert.IsNotInstanceOfType() test.")]
        [Owner("{developer/team name}")]
        public void IsNotInstanceOfTypeTest()
        {
            Assert.IsNotInstanceOfType(_spaceship1, typeof(Person), "'spaceship' was a Person.");
        }

        [TestMethod]
        [TestCategory("ObjectAssert Tests")]
        [Description("Demo of the Assert.IsInstanceOfTypeTest() test.")]
        [Owner("{developer/team name}")]
        public void IsInstanceOfTypeTest()
        {
            Assert.IsInstanceOfType(_spaceship1, typeof(Spaceship), "'spaceship' was not a Spaceship.");
        }

        [TestMethod]
        [TestCategory("ObjectAssert Tests")]
        [Description("Demo of the Assert.AreNotEqual() test for objects.")]
        [Owner("{developer/team name}")]
        public void TypesAreNotEqualTest()
        {
            Assert.AreNotEqual(_spaceship1, _spaceship2, "spaceship1 and spaceship2 has the same reference.");
        }
    }
}
