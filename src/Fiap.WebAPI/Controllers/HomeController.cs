using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ICadastroApplicaionService _usuarioApplicationService;
        public HomeController(ICadastroApplicaionService usuarioApplicationService)
        {
            _usuarioApplicationService = usuarioApplicationService;
        }

        [HttpPost("AdicionarCadastro")]
        public ActionResult AdicionarUsuario(CadastroViewModel cadastrViewModel)
        {
            if (ModelState.IsValid)
                return Ok(_usuarioApplicationService.AdicionarCadastro(cadastrViewModel));

            return NotFound("Erro ao cadastrar");
        }

        [HttpDelete("DeletarCadastro")]
        public ActionResult DeletarCadastro(Guid id)
        {
            if (ModelState.IsValid)
                _usuarioApplicationService.DeletarCadastro(id);

            return Ok("Cadastro excluido com sucesso!");
        }

        [HttpPut("AtualizarCadastro")]
        public ActionResult AtualizarCadastro(CadastroViewModel cadastrViewModel)
        {
            if (ModelState.IsValid)
                return Ok(_usuarioApplicationService.AtualizarCadastro(cadastrViewModel));
            
            return NotFound("Erro ao cadastrar");
        }

        [HttpGet("ObterCadastro")]
        public ActionResult ObterCadastro(Guid id)
        {
            var cadastro = _usuarioApplicationService.ObterCadastro(id);

            return Ok(cadastro);
        }

        [HttpGet("ListarCadastro")]
        public ActionResult ListarCadastro()
        {
            var cadastros = _usuarioApplicationService.ObterCadastros();

            return Ok(cadastros);
        }

        [HttpGet("ListarEstabeleciemtno")]
        public ActionResult ListarEstabeleciemtno()
        {
            var teste = _usuarioApplicationService.ObterEstabeleciemento();

            return Ok(teste);
        }
    }
}
