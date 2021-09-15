using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubeSquad.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Passeio> Passeios { get; set; }
        public DbSet<Pedido_Loja> Pedido_Lojas { get; set; }
        public DbSet<Pedido_Restaurante> Pedido_Restaurantes { get; set; }
        public DbSet<Produto_Loja> Produto_Lojas { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}
