using Microsoft.EntityFrameworkCore;
using PizzariaAspNet.Models;

namespace PizzariaAspNet.Data;

public class AppDbContext : DbContext
{
    // Construtor que aceita DbContextOptions<AppDbContext>
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }

    public DbSet<PizzaModel> Pizzas { get; set; }
}
