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
        public override string ToString() => $"Location: {this.LocationName}";
        //TODO: add some property for the location inventory
    }
}