using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stack.Core.Managers;
using Stack.DAL;
using Stack.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Core
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext context;
        public UnitOfWork(ApplicationDbContext context, CustomerManager customerManager, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            CustomerManager = customerManager;
            RoleManager = roleManager;
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return await context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // log message and entries
            }
            catch (DbUpdateException ex)
            {
                // log message and entries
            }
            catch (Exception ex)
            {
                // Log here.
            }
            return false;
        }
        public CustomerManager CustomerManager { get; private set; } //Manager for application users
        public RoleManager<IdentityRole> RoleManager { get; private set; } //Manager for application user roles

        private VehicleManager vehicleManager;
        public VehicleManager VehicleManager
        {
            get
            {
                if (vehicleManager == null)
                {
                    vehicleManager = new VehicleManager(context);
                }
                return vehicleManager;
            }
        }

       

    }
}
