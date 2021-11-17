using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Stack.DAL;
using Stack.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack.Core.Managers
{
    public class CustomerManager : UserManager<Customer>
    {
        public DbSet<Customer> dbSet;
        public ApplicationDbContext context;
        public CustomerManager(ApplicationDbContext _context, IUserStore<Customer> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<Customer> passwordHasher, IEnumerable<IUserValidator<Customer>> userValidators, IEnumerable<IPasswordValidator<Customer>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<Customer>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {

            dbSet = _context.Set<Customer>();
            context = _context;

        }


        public async Task<Customer> GetCustomerById(string userId)
        {
            return await Task.Run(() =>
            {
                var usersResult = dbSet.Where(a => a.Id == userId);
                if (usersResult.ToList().Count != 0)
                {

                    var applicationUserToReturn = usersResult.ToList().FirstOrDefault();

                    return applicationUserToReturn;

                }
                else
                {
                    return null;
                }
            });
        }

        public async Task<List<Customer>> GetAllCustomersExcept(string userId)
        {
            return await Task.Run(() =>
            {
                var applicationUser = dbSet.Where(a => a.Id != userId);
                if (applicationUser.ToList().Count != 0)
                    return applicationUser.ToList();
                else
                    return null;

            });
        }


        public async Task<List<Customer>> GetAllCustomers()
        {
            return await Task.Run(() =>
            {
                var applicationUser = dbSet.Where(a => a.Id != null);
                if (applicationUser.ToList().Count != 0)
                    return applicationUser.ToList();
                else
                    return null;
            });
        }
    }
}
