﻿
using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Infra.Data.Repositories
{
    /// <summary>
    /// Repositório de dados para produto
    /// </summary>
    public class ProdutoRepository : BaseRepository<Produto, Guid?>, IProdutoRepository
    {
        public ProdutoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
