using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelaDeCadastro.WebAPI.Models;

namespace TelaDeCadastro.WebAPI.Data
{
    public class Cadastro : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Cadastro(DbContextOptions<Cadastro> options)
            : base(options)
        {
        }
    }
}

