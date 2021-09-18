using BancoCunha.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoCunha.Data
{
    public class MySqlContext : DbContext
    {


        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {

        }

        public DbSet<BancoCunha.Models.Banco> Banco { get; set; }
        public DbSet<BancoCunha.Models.Conta> Conta { get; set; }
        public DbSet<BancoCunha.Models.MovimentacaoBancaria> MovimentacaoBancaria { get; set; }
        public DbSet<BancoCunha.Models.Pessoa> Pessoa { get; set; }
        public DbSet<BancoCunha.Models.SaldoPessoa> SaldoPessoa { get; set; }


        public string ConnectionString { get; set; }
        private MySqlConnection GetConnection()
        {

            return new MySqlConnection(ConnectionString);
        }
    }
}

