using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Certificates_Validator_Server_Project.Data.Models;

namespace Certificates_Validator_Server_Project.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }


        public DbSet<FileSec> Files { get; set; }

    }
}
