using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Data.Context;
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

        [HttpPost("AdicionarUsuario")]
        public ActionResult AdicionarUsuario(CadastroViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
                _usuarioApplicationService.AdicionarUsuario(usuarioViewModel);

            return Ok();
        }

        [HttpGet("ListarUsuario")]
        public ActionResult ListarUsuario()
        {
            if (ModelState.IsValid)
                _usuarioApplicationService.ObterUsuarios();

            return Ok();
        }

        [HttpGet("ListarEstabeleciemtno")]
        public ActionResult ListarEstabeleciemtno()
        {
            var teste = _usuarioApplicationService.ObterEstabeleciemento();

            return Ok(teste);
        }
    }
}
