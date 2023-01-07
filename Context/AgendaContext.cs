using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Criacao_API_DIO_CSharp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Criacao_API_DIO_CSharp.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){

        }

        public DbSet<Contato> Contatos { get; set; }
        
    }
}