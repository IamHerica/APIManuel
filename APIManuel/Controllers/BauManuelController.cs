using APIManuel.Business;
using APIManuel.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIManuel.Controllers
{
    [ApiController][Route("api/[controller]")]
    public class BauManuelController : Controller
    {
        private readonly IBauManuelBusiness _bauManuelBusiness;
        public BauManuelController(IBauManuelBusiness bauManuelBusiness)
        {
            _bauManuelBusiness = bauManuelBusiness;
        }

        [HttpGet] 
        public async Task<ActionResult<BrinquedoReadDTO>> GetBrinquedo(Guid guid)
        {
            var retorno = await _bauManuelBusiness.GetBrinquedo(guid);

            return retorno == default ? NotFound("Brinquedo não encontrado") : Ok(retorno);
        }

        [HttpGet("ListAll")]
        public async Task<ActionResult<List<BrinquedoReadDTO>>> GetAllBrinquedo()
        {
            return Ok(await _bauManuelBusiness.GetAllBrinquedos());
        }

        [HttpPost]
        public async Task<ActionResult<BrinquedoReadDTO>> CreateBrinquedo(BrinquedoCreateDTO brinquedo)
        {
            //Pega o parametro a ser recebido, e o modelState irá verificar se é valido
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            return Ok(await _bauManuelBusiness.CreateBrinquedo(brinquedo));
        }

        
    }
}
