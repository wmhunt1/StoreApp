using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class LocationBL : ILocationBL
    {
        private ILocationRepository _repo;
        public LocationBL(ILocationRepository repo)
        {
            _repo = repo;
        }
        public void AddLocation(Location newLocation)
        {
            //Todo: Add BL
            _repo.AddLocation(newLocation);
        }

        public List<Location> GetLocations()
        {
            //TODO add BL
            return _repo.GetLocations();
        }
        public Location GetLocationByName(string name)
        {
            return _repo.GetLocationByName(name);
        }
        public void UpdateLocation(Location location2BUpdated, Location updatedDetails)
        {
            location2BUpdated.LocationName = updatedDetails.LocationName;
            location2BUpdated.StreetAddress = updatedDetails.StreetAddress;
            location2BUpdated.LocationInventory1 = updatedDetails.LocationInventory1;
            location2BUpdated.LocationInventory2 = updatedDetails.LocationInventory2;
            location2BUpdated.LocationInventory3 = updatedDetails.LocationInventory3;
            _repo.UpdateLocation(location2BUpdated);
        }
    }
}