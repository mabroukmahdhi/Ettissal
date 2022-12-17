// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Ettissal.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Ettissal.Extensions
{
    public static class EttissalExtensions
    {
        public static void AddEttissal(this IServiceCollection services)
        {
            services.AddScoped<IConnectionService, ConnectionService>();
        }
    }
}