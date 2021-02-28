using System;

namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a store location.
    /// </summary>
    public class Location
    {
        private string streetAddress;
        private string locationName;

        private int locationInventory;
        public string StreetAddress {
            get {return streetAddress;}
            set {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Address can't be empty or null");
                }
                streetAddress = value;

            }
        }
        public string LocationName {
             get {return locationName;}
            set {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("location name can't be empty or null");
                }
                locationName = value;

            }
        }
        public int LocationInventory {get; set;}
        public override string ToString() => $"Location: {this.LocationName}";
        public string GetInventory() => $"{this.LocationInventory} cans of soup";
        //TODO: add some property for the location inventory
    }
}