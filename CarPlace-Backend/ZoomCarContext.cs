using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CarPlace_Backend
{
    public class ZoomCarContext:DbContext
    {
        public DbSet<Models.CarModel> CarModel { get; set; }
        public DbSet<Models.CarDetails> CarDetails { get; set; }
        public DbSet<Models.OrderDetails> OrderDetails { get; set; }
        public DbSet<Models.ZoomCarUser> ZoomCarUser { get; set; }
        public ZoomCarContext(DbContextOptions option) :base(option)
        { }
       


    }
}
