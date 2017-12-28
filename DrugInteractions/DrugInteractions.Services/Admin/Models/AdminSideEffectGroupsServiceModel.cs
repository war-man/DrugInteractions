﻿using DrugInteractions.Common.Mapping;
using DrugInteractions.Data.Models.SideEffects;

namespace DrugInteractions.Services.Admin.Models
{
    public class AdminSideEffectGroupsServiceModel : IMapFrom<SideEffectGroup>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
