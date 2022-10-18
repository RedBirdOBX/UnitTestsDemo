namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Demo of the different collection assert tests.</summary>
    [TestClass]
    public class CollectionAssertClassTests
    {
        private static List<Spaceship> _spaceships;
        private static List<string> _strings1;
        private static List<string> _strings2;
        private static List<string> _strings3;

        [TestInitialize]
        public void CollectionAssertClassTestsInit()
        {
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

            _strings1 = new List<string>() { "a", "b", "c" };
            _strings2 = new List<string>() { "a", "b", "c" };
            _strings3 = new List<string>() { "c", "b", "a" };
        }


        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.Contains().")]
        [Owner("{developer/team name}")]
        public void ContainsTest()
        {
            CollectionAssert.Contains(_strings1, "a", "Does not contain 'a'.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.DoesNotContainTest().")]
        [Owner("{developer/team name}")]
        public void DoesNotContainTest()
        {
            CollectionAssert.DoesNotContain(_strings1, "d", "Contains 'd' and that's bad.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.AreEqualTest().")]
        [Owner("{developer/team name}")]
        public void AreEqualTest()
        {
            CollectionAssert.AreEqual(_strings1, _strings2, "Lists of strings are not equal.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.AreNotEqual().")]
        [Owner("{developer/team name}")]
        public void AreNotEqualTest()
        {
            CollectionAssert.AreNotEqual(_strings2, _strings3, "Lists of strings are equal...and shouldn't be.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.AreEquivalent().")]
        [Owner("{developer/team name}")]
        public void AreEquivalentTest()
        {
            CollectionAssert.AreEquivalent(_strings2, _strings3, "Lists do not have the same values.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.AllItemsAreInstancesOfType().")]
        [Owner("{developer/team name}")]
        public void AllItemsAreInstancesOfTypeTest()
        {
            CollectionAssert.AllItemsAreInstancesOfType(_spaceships, typeof(Spaceship), "List does not contain Spaceships.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate CollectionAssert.AllItemsAreUniqueTest().")]
        [Owner("{developer/team name}")]
        public void AllItemsAreUniqueTest()
        {
            CollectionAssert.AllItemsAreUnique(_strings1, "All items are not unique.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate how to use Assert.IsTrue() on collection.")]
        [Owner("{developer/team name}")]
        public void IsTrueOnCollectionTest()
        {
            Assert.IsTrue(_spaceships.Any(s => s.Designation == "NCC1701D"), "Spaceships requires the Enterprise D.");
        }

        [TestMethod]
        [TestCategory("CollectionAssert Tests")]
        [Description("Example to demonstrate how to use Assert.IsFalse() on collection.")]
        [Owner("{developer/team name}")]
        public void IsFalseOnCollectionTest()
        {
            Assert.IsFalse(_spaceships.Any(s => s.Designation == string.Empty), "All Spaceships require Designation.");
        }
    }
}