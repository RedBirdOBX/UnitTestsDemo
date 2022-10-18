namespace UnitTestDemo.Test.TestData
{
    public class Spaceship
    {
        public Spaceship()
        {
            Name = string.Empty;
            Designation = string.Empty;
        }


        public Guid Id { get; set; }

        public string Name { get; set; }

        public ShipClassification Classification { get; set; }

        public string Designation { get; set; }

        public int CrewCapacity { get; set; }

        public int PassengerCapacity { get; set; }

        public int TotalCapacity { get { return CrewCapacity + PassengerCapacity; } }

        public bool? HasWarp { get; set; }

        public const string AdmiralOfFleet = "Shane of course";

        public DateTime CommissionedDate { get; set; }

        public DateTime? DecommissionedDate { get; set; }

        public string GetAutoDestructSequence()
        {
            throw new NotImplementedException("This method is incomplete.");
        }
    }
}
