using Mediator.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mediator.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}