﻿using DAL.Interface;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CountryRepository : BaseRepository, ICountryRepository
    {
        public bool AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public IList<Country> GetAllCountry()
        {
            IList<Country> customerList = SqlMapper.Query<Country>(con, "GetAllCountries", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public Country GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
