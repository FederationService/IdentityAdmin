﻿using IdentityAdmin.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityAdminApiBuilderExtensions
    {
        public static IIdentityAdminCoreBuilder AddApiExplorer(this IIdentityAdminCoreBuilder builder)
        {
            return builder;
        }
    }
}