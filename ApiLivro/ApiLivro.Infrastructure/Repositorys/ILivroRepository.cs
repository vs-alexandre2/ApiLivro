using ApiLivro.ApiLivro.Application.Services;
using ApiLivro.ApiLivro.Domain.Models;

namespace ApiLivro.ApiLivro.Infrastructure.Repositorys
{
    public interface ILivroRepository
    {
        Task<LivroServiceResponse<List<LivroModel>>> GetLivros();
        Task<LivroServiceResponse<List<LivroModel>>> CreateLivro(LivroModel novoLivro);
        Task<LivroServiceResponse<LivroModel>> GetLivroById(int id);
        Task<LivroServiceResponse<List<LivroModel>>> UpdateLivro(LivroModel editadoLivro);
        Task<LivroServiceResponse<List<LivroModel>>> DeleteLivro(int id);
    }
}
