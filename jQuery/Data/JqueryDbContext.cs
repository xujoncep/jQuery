using Microsoft.EntityFrameworkCore;

namespace jQuery.Data
{
    public class JqueryDbContext : DbContext
    {

        public JqueryDbContext(DbContextOptions<JqueryDbContext> options) : base(options)
        {

        }


    }
}
