﻿using DrugInteractions.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrugInteractions.Services
{
    public interface IDrugService
    {
        Task<IEnumerable<DrugListingServiceModel>> FindAsync(string searchText);
    }
}