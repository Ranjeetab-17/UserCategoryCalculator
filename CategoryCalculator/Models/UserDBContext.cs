using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CategoryCalculator.Models
{
    public class UserDBContext : DbContext
    {
        public DbSet<UserInput> userInputs { get; set; }
    }
}