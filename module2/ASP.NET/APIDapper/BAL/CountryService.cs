﻿using BAL.Interface;
using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL
{
    public class CountryService : ICountryService
    {
        ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

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
            return _countryRepository.GetAllCountry();
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
