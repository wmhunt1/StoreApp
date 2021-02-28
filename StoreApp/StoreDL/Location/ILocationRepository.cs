using StoreModels;
using System.Collections.Generic;
namespace StoreDL
{
    public interface ILocationRepository
    {
        List<Location> GetLocations();
        Location AddLocation(Location newLocation);
        Location GetLocationByName(string name);

         void UpdateLocation(Location location2BUpdated);
    }
}