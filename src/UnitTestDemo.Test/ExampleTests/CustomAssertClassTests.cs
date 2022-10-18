namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of custom assert classes.</summary>
    [TestClass]
    public class CustomAssertClassTests
    {
        private static Person _person;
        private static List<Spaceship> _spaceships;


        [TestInitialize]
        public void CustomAssertClassTestsInit()
        {
            _person = new Person()
            {
                Name = "Ricky Bobby",
                Age = 50
            };

            _spaceships = new List<Spaceship>()
            {
                new Spaceship
                {
                    Id = new Guid("1fa8275b-4ad7-4851-b8b3-44448fb06b0a"),
                    Classification = ShipClassification.Galaxy,
                    Designation = "NCC1701D",
                    Name  = "USS Enterprise D",
                    CrewCapacity = 800,
                    PassengerCapacity = 200,
                    CommissionedDate = new DateTime(2400,01,01),
                },
                new Spaceship
                {
                    Id = new Guid("73389722-91e3-45cd-8a56-e14b73abd258"),
                    Classification = ShipClassification.Defiant,
                    Designation = "NX-74205",
                    Name  = "ISS Defiant",
                    CrewCapacity = 10,
                    PassengerCapacity = 5,
                    CommissionedDate = new DateTime(2400,01,01),
                }
            };
        }

        [TestMethod]
        [TestCategory("CustomAssert Tests")]
        [Description("A method to test and use a custom made Assert: 'IsInRange'.")]
        [Owner("{developer/team name}")]
        public void IsInRangeCustomTest()
        {
            Assert.That.IsInRange(_person.Age, 1, 100);
        }

        [TestMethod]
        [TestCategory("CustomAssert Tests")]
        [Description("A method to test and use a custom made Assert: 'AllSpaceshipNamesNotNullOrWhitespace'.")]
        [Owner("{developer/team name}")]
        public void AllSpaceshipNamesHaveValueCustomTest()
        {
            CollectionAssert.That.AllSpaceshipNamesNotNullOrWhitespace(_spaceships);
        }

        [TestMethod]
        [TestCategory("CustomAssert Tests")]
        [Description("A method to test and use a custom made CollectionAssert: 'AllItemsSatisfyCustomTest'.")]
        [Owner("{developer/team name}")]
        public void AllItemsSatisfyCustomTest()
        {
            CollectionAssert.That.AllItemsSatisfyCustomTest(_spaceships, s => !string.IsNullOrWhiteSpace(s.Name));
        }

        [TestMethod]
        [TestCategory("CustomAssert Tests")]
        [Description("A method to test and use a custom made CollectionAssert: 'All'.")]
        [Owner("{developer/team name}")]
        public void AllItemsSatisfyAllAssertsCustomTest()
        {
            // run multiple rules against each item in collection!
            CollectionAssert.That.All(_spaceships, s =>
            {
                StringAssert.StartsWith(s.Designation, "N");
                Assert.That.IsInRange(s.PassengerCapacity, 1, 1000);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(s.Name));
                Assert.IsTrue(s.CrewCapacity > 0);
                Assert.IsTrue(s.PassengerCapacity > 0);
            });
        }
    }
}
