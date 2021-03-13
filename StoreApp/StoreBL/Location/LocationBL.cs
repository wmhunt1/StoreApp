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
        public Location DeleteLocation(Location location2BDeleted)
        {
            return _repo.DeleteLocation(location2BDeleted);
        }
        public Location UpdateLocation(Location location2BUpdated)
        {
             return _repo.UpdateLocation(location2BUpdated);
        }
    }
}