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

        public static Talk Map2Talk(Talk oldTalk, TalkModel model)
        {
            
            oldTalk.Title = model.Title;
            oldTalk.Abstract = model.Abstract;
            oldTalk.Level = model.Level;
            if (oldTalk.Speaker is null)
            {
                oldTalk.Speaker = new Speaker();
            }

            oldTalk.Speaker.SpeakerId = model.Speaker.SpeakerId;
            oldTalk.Speaker.FirstName = model.Speaker.FirstName;
            oldTalk.Speaker.LastName = model.Speaker.LastName;
            oldTalk.Speaker.MiddleName = model.Speaker.MiddleName;
            oldTalk.Speaker.Company = model.Speaker.Company;
            oldTalk.Speaker.CompanyUrl = model.Speaker.CompanyUrl;
            oldTalk.Speaker.BlogUrl = model.Speaker.BlogUrl;
            oldTalk.Speaker.Twitter = model.Speaker.Twitter;
            oldTalk.Speaker.GitHub = model.Speaker.GitHub;

            return oldTalk;
        }

        public static Talk[] Map2Talks(Talk[] orig, TalkModel[] talks)
        {
            for (int i = 0; i < talks.Length; i++)
                Map2Talk(orig[i], talks[i]);

            return orig;
        }


    }
}
