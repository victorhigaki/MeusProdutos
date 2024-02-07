using DevIO.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFOrnecedorEndereco(Guid id);
        Task<Fornecedor> ObterFOrnecedorProdutosEndereco(Guid id);
    }
}
