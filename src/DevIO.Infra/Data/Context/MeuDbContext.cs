﻿using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Produtos;
using System.Data.Entity;

namespace DevIO.Infra.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext() : base("DefaultConnection")
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}
