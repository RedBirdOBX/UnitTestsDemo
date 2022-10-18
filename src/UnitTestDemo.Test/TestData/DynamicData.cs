namespace UnitTestDemo.Test.TestData
{
    public static class DynamicData
    {
        // https://github.com/Microsoft/testfx-docs/blob/main/RFCs/006-DynamicData-Attribute.md
        // https://app.pluralsight.com/course-player?clipId=63693450-47aa-4d1d-807a-eb608d66e268
        // You can also use this pattern to access external data such as a db or csv file.
        // the key is that it must return a IEnumerable<object[]>.

        public static IEnumerable<object[]> GetNumbers()
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
