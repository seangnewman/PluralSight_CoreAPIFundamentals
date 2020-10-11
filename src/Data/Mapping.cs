using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public static class Mapping
    {
        public static Camp Map2Camp(Camp oldCamp, CampModel  model)
        {
            oldCamp.Name = model.Name;
            oldCamp.EventDate = model.EventDate;
            oldCamp.Moniker = model.Moniker;
            oldCamp.Length = model.Length;

            if(oldCamp.Location is null)
            {
                oldCamp.Location = new Location();
            }

            oldCamp.Location.Address1 = model.LocationAddress1;
            oldCamp.Location.Address2 = model.LocationAddress2;
            oldCamp.Location.Address3 = model.LocationAddress3;
            oldCamp.Location.CityTown = model.LocationCityTown;
            oldCamp.Location.StateProvince = model.LocationStateProvince;
            oldCamp.Location.PostalCode = model.LocationPostalCode;
            oldCamp.Location.Country = model.LocationCountry;

            return oldCamp;

        }


    }
}
