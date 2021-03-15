using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomersApi.Objects;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CustomersApi.DbContexts
{
    public class CustomerContext : DbContext
    {
        public virtual DbSet<CustomerObject> TbCustomers { get; set; }


        public CustomerContext(DbContextOptions<CustomerContext> dbContextOptions) : base(dbContextOptions) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (IServiceScope serviceScope = applicationBuilder.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<CustomerContext>();
                context.Database.EnsureCreated();
            }
        }

    }
}
