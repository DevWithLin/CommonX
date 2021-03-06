﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonX.Mapster
{
    /// <summary>
    ///     Maps both, eneity and dto two-way.
    /// </summary>
    /// <seealso cref="AutoMapAttributeBase" />
    public class AutoMapAttribute : AutoMapAttributeBase
    {
        public AutoMapAttribute(params Type[] targetTypes)
            : base(targetTypes)
        {
        }

        public override void CreateMap(TypeAdapterConfig configuration, Type needstoMap)
        {
            if (TargetTypes.IsNullOrEmpty())
            {
                return;
            }

            foreach (Type source in TargetTypes)
            {
                configuration.NewConfig(source, needstoMap);
                configuration.NewConfig(needstoMap, source);
            }
        }
    }
}
