using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{

    [HttpGet(Name = "Pessoa")]
    public IActionResult Get(){

        PessoaService pessoaService = new PessoaService();
        return Ok(pessoaService.GetAll());
    }
}
