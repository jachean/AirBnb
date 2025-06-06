﻿using AirBnb.Models;

namespace AirBnb.Repositories
{
    public interface IPropertyRepository : IRepository<Property>
    {
        Task<IEnumerable<Property>> GetPropertiesByLocationAsync(string location);
        Task<Property> GetPropertyWithDetailsAsync(int propertyId);
        Task<IEnumerable<Property>> GetPropertiesWithImagesAsync();
        Task<IEnumerable<Property>> SearchPropertiesAsync(string searchTerm);
    }
}
