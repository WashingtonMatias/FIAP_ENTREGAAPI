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
        private readonly IUsuarioApplicaionService _usuarioApplicationService;

        public HomeController(IUsuarioApplicaionService usuarioApplicationService)
        {
            _usuarioApplicationService = usuarioApplicationService;
        }

        [HttpPost("AdicionarUsuario")]
        public ActionResult AdicionarUsuario(UsuarioViewModel usuarioViewModel)
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
    }
}
