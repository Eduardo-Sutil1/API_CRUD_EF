using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaApi.Entities; // Importanto a classe contato

namespace MinhaApi.Context
{
    public class AgendaContext : DbContext // Essa classe vai servir pra conectar ao banco
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) // Construtor para conectar ao banco
        {

        }

        public DbSet<Contato> Contatos { get; set; } // Propriedade que refere a entidade (Classe e Tabela)
    }
}