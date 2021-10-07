using APIManuel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIManuel.Data
{
    public class BauManuelContext : DbContext
    {
        //Construtor do contexto do banco
        public BauManuelContext()
        {
            //Criar um banco de dados caso nao tenha um arquivo do banco de dados
            Database.EnsureCreated();
        }

        //Confira o banco 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Configura o arquivo do Sqlite
            options.UseSqlite("Data Source=bancodedados.db");
        }


        //DbSet é uma lista de um modelo
        public DbSet<Brinquedo> Brinquedos { get; set; }
        

    }
}
