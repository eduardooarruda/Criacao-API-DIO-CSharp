using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Criacao_API_DIO_CSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora(){
            //objeto anonimo
            var obj = new
            {
                Data = DateTime.Now.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }
        
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            string mensagem = $"Seja bem vindo {nome}!";
            return Ok(new { mensagem });
        }
        
    }
}