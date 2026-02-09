using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiLivro.ApiLivro.Domain.Models;
using ApiLivro.ApiLivro.Infrastructure.Repositorys;
using ApiLivro.ApiLivro.Application.Services;

namespace ApiLivro.ApiLivro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _LivroRepository;
        public LivroController(ILivroRepository LivroRepository)
        {
            _LivroRepository = LivroRepository;
        }

        [HttpGet]
        public async Task<ActionResult<LivroServiceResponse<List<LivroModel>>>> GetLivros()
        {
            return Ok( await _LivroRepository.GetLivros());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroServiceResponse<LivroModel>>> GetLivroById(int id)
        {
            LivroServiceResponse<LivroModel> serviceResponse = await _LivroRepository.GetLivroById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<LivroServiceResponse<List<LivroModel>>>> CreateLivro(LivroModel novoLivro)
        {
            return Ok(await _LivroRepository.CreateLivro(novoLivro));
        }

        [HttpPut]
        public async Task<ActionResult<LivroServiceResponse<List<LivroModel>>>> UpdateLivro(LivroModel editadoLivro)
        {
            LivroServiceResponse<List<LivroModel>> serviceResponse = await _LivroRepository.UpdateLivro(editadoLivro);

            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<LivroServiceResponse<List<LivroModel>>>> DeleteLivro(int id)
        {
            LivroServiceResponse<List<LivroModel>> serviceResponse = await _LivroRepository.DeleteLivro(id);

            return Ok(serviceResponse);

        }

    }
}
