using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WakeProApi.Data
{
   public class DataContext : IdentityDbContext
   {
      public DataContext(DbContextOptions<DataContext> options) : base(options)
      {

      }
   }
}
