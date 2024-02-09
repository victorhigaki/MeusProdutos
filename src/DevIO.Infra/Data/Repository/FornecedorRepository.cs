using DevIO.Business.Models.Fornecedores;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFOrnecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .Include(f => f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        //public async Task<Fornecedor> TesteAsync()
        //{
        //    return Buscar(f => f.Ativo && f.Documento == "" && f.Nome == "")
        //        .Result.FirstOrDefault();
        //}

        //public override async Task Remover(Guid id)
        //{
        //    var fornecedor = await ObterPorId(id);
        //    fornecedor.Ativo = false;
        //    await Atualizar(fornecedor);
        //}
    }
}
