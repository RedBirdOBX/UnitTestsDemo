namespace UnitTestDemo.Test.Extensions
{
    /// <summary>Extension Methods.  Write your own custom Assert methods!</summary>
    public static class CustomAsserts
    {
        public static void IsInRange(this Assert assert, int actual, int expectedMinVal, int expectedMaxVal)
        {
            if (actual < expectedMinVal || actual > expectedMaxVal)
            {
                throw new AssertFailedException($"{actual} was not in the range of {expectedMinVal} -- {expectedMaxVal}.");
            }
        }

        public static void AllSpaceshipNamesNotNullOrWhitespace(this CollectionAssert collectionAssert, ICollection<Spaceship> spaceships)
        {
            foreach (var ship in spaceships)
            {
                if (string.IsNullOrWhiteSpace(ship.Name))
                {
                    throw new AssertFailedException($"One of more items was null or had whitespace.");
                }
            }
        }

        public static void AllItemsSatisfyCustomTest<T>(this CollectionAssert collectionAssert, ICollection<T> collection, Predicate<T> predicate)
        {
            // more flexible!  pass in a collection AND your test and it will run the test based on your predicate.
            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    throw new AssertFailedException("All items do not satisfy predicate.");
                }
            }
        }

        public static void All<T>(this CollectionAssert collectionAssert, ICollection<T> collection, Action<T> assert)
        {
            // this allows you to take **multiple** asserts/action against each item.
            foreach (var item in collection)
            {
                assert(item);
            }
        }
    }
}
