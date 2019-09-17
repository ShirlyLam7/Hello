using Hello.Models;
using Microsoft.EntityFrameworkCore;

namespace Hello.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }

        public DbSet<Value> Values {get;set;}//the variable name will be used for the table name in DB
    }
}