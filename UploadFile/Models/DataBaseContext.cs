using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadFile.Entidades;

namespace UploadFile.Models
{
    public class DataBaseContext : DbContext
    {
        internal object Intercambio;

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            :base(options)
        {

        }
        public DbSet<Files> Files { get; set; }
        public DbSet<Intercambio> Intercambios { get; set; }


    }
}
