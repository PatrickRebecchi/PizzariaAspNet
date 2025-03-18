﻿using Microsoft.EntityFrameworkCore;
using PizzariaAspNet.Models;

namespace PizzariaAspNet.Data;

public class AppDbContext : DbContext
{
    // Construtor que aceita DbContextOptions<AppDbContext>
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=pizzariaaspnet;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");


    public DbSet<PizzaModel> Pizzas { get; set; }
}
