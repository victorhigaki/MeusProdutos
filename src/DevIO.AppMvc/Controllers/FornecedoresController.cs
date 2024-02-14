using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Fornecedores.Services;
using DevIO.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DevIO.AppMvc.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController()
        {
            _fornecedorService = new FornecedorService(new FornecedorRepository(), new EnderecoRepository());
        }

        // GET: Fornecedores
        public async Task<ActionResult> Index()
        {
            var fornecedor = new Fornecedor()
            {
                Nome = "Eduardo",
                Documento = "30390600822",
                Endereco = new Endereco
                {
                    Logradouro = "Rua Teste",
                    Numero = "123",
                    Complemento = "Teste",
                    Bairro = "Teste",
                    Cep = "12345678",
                    Cidade = "Teste",
                    Estado = "Teste",
                },
                TipoFornecedor = TipoFornecedor.PessoaFisica,
                Ativo = true
            };

            await _fornecedorService.Adicionar(fornecedor);

            return new EmptyResult();
        }
    }
}