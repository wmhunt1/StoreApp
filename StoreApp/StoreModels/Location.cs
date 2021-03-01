using System;

namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a store location.
    /// </summary>
    public class Location
    {
        private int locationId;
        private string streetAddress;
        private string locationName;

        private int locationInventory1;
        private int locationInventory2;
        private int locationInventory3;
        public int? LocationId { get; set; }
        public string StreetAddress
        {
            get { return streetAddress; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Address can't be empty or null");
                }
                streetAddress = value;

            }
        }
        public string LocationName
        {
            get { return locationName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("location name can't be empty or null");
                }
                locationName = value;

            }
        }
        public int LocationInventory1 { get; set; }
        public int LocationInventory2 { get; set; }
        public int LocationInventory3 { get; set; }
        public override string ToString() => $"Location: {this.LocationName}, ID# {this.LocationId}";
        public string GetInventory() => $"{this.LocationInventory1} cans of soup, {this.LocationInventory2} bowls, and {this.LocationInventory3} spoons";
        //TODO: add some property for the location inventory
    }
}