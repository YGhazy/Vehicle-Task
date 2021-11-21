﻿
using Microsoft.Extensions.DependencyInjection;
using Stack.API.Hubs;
using Stack.DTOs.Models;
using Stack.Repository.Common;
using Stack.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack.API.Extensions
{
    public static class ServiceExtensions
    {
        //Referencing service files to be injected into the API Controllers . 
        public static void AddBusinessServices(this IServiceCollection caller)
        {

            caller.AddScoped<ApplicationUsersService>();
            caller.AddScoped<VehicleService>();
            caller.AddScoped<InitializerService>();
            caller.AddScoped<NotificationsHub>();

        }

    }
}
