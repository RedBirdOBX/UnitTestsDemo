namespace UnitTestDemo.Test.ExampleTests
{
    /// <summary>Dynamic Data tests</summary>
    [TestClass]
    public class DynamicDataClassTests
    {
        public static IEnumerable<object[]> Numbers
        {
            get
            {
                return new List<object[]>
                {
                    new object[] { 10, 10, 20},
                    new object[] { 20, 20, 40},
                    new object[] { 30, 30, 60}
                };
            }
        }


        [DataTestMethod]
        [DataRow(10, 10, 20)]
        [DataRow(20, 20, 40)]
        [DataRow(30, 30, 60)]
        [TestCategory("DynamicDataClass Tests")]
        [Description("Example of inline, explicit data tests. Will be ran for each DataRow attribute found.")]
        [Owner("{developer/team name}")]
        public void DataRowAttributeTests(int a, int b, int expected)
        {
            int total = Calculate(a, b);
            Assert.AreEqual(total, expected, "Not equal.");
        }

        [DataTestMethod]
        [TestCategory("DynamicDataClass Tests")]
        [Description("Example of referencing an object for the source of the data. Uses DynamicData attribute.")]
        [Owner("{developer/team name}")]
        [DynamicData(nameof(Numbers))]
        public void CollectionObjectExampleDataTests(int a, int b, int expected)
        {
            int total = Calculate(a, b);
            Assert.AreEqual(total, expected, "Not equal.");
        }

        [DataTestMethod]
        [TestCategory("DynamicDataClass Tests")]
        [Description("Example of referencing a method for the source of the data. Uses DynamicData attribute.")]
        [Owner("{developer/team name}")]
        [DynamicData(nameof(GetNumbers), DynamicDataSourceType.Method)]
        public void CollectionMethodForDataTests(int a, int b, int expected)
        {
            int total = Calculate(a, b);
            Assert.AreEqual(total, expected, "Not equal.");
        }

        [DataTestMethod]
        [TestCategory("DynamicDataClass Tests")]
        [Description("Example of referencing a external class for the source of the data.")]
        [DynamicData(nameof(DynamicData.GetNumbers), typeof(DynamicData), DynamicDataSourceType.Method)]
        [Owner("{developer/team name}")]
        public void CollectionClassForDataTests(int a, int b, int expected)
        {
            int total = Calculate(a, b);
            Assert.AreEqual(total, expected, "Not equal.");
        }


        private int Calculate(int a, int b)
        {
            return a + b;
        }

        private static IEnumerable<object[]> GetNumbers()
        {
            return new List<object[]>()
            {
                new object[] { 10, 10, 20},
                new object[] { 20, 20, 40},
                new object[] { 30, 30, 60}
            };
        }
    }
}