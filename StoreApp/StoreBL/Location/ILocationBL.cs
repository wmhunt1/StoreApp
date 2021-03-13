using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface ILocationBL
    {
        List<Location> GetLocations();
        void AddLocation(Location newLocation);
        Location GetLocationByName(string name);
        Location DeleteLocation(Location location2BDeleted);
        Location UpdateLocation(Location location2BUpdated);

    }
}