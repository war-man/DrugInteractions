﻿using DrugInteractions.Data.Models.SideEffects;
using DrugInteractions.Services.Repr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrugInteractions.Services.Repr
{
    public interface IReprSideEffectsService
    {
        Task<IEnumerable<ReprSideEffectListingServiceModel>> AllAsync();

        Task<bool> CreateAsync(SideEffect model);

        Task<bool> UpdateAsync(SideEffect model);

        Task<SideEffect> GetByIdAsync(int id);

        Task DeleteAsync(SideEffect model);

        Task DrugsInSideEffect(IEnumerable<int> drugIds, int sideEffectId);
    }
}
