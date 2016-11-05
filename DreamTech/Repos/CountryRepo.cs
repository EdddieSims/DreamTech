using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class CountryRepo
    {
        public List<console.Models.tblCountry> GetAllCountries()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tblCountries.Where(t => t.country_id > 0).ToList();
            }
        }

        public bool SaveCountry(console.Models.tblCountry entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tblCountries.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteCountry(console.Models.tblCountry entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tblCountries.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}