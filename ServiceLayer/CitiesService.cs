﻿using ServiceContracts;

namespace ServiceLayer;

public class CitiesService : ICitiesService
{
    private List<string> _cities;

    public CitiesService()
    {
        _cities = new List<string>()
        {
            "London",
            "paris",
            "Delhi",
            "Pune",
            "Dallas"
        };
    }

    public List<string> GetCities()
    {
        return _cities;

    }

}

