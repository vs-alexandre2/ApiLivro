using Microsoft.EntityFrameworkCore;
using ApiLivro.ApiLivro.Infrastructure.DataContexts;
using ApiLivro.ApiLivro.Domain.Models;
using ApiLivro.ApiLivro.Application.Services;

namespace ApiLivro.ApiLivro.Infrastructure.Repositorys
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LivroDbContext _context;
        public LivroRepository(LivroDbContext context)
        {
            _context = context;
        }

        public async Task<LivroServiceResponse<List<LivroModel>>> CreateLivro(LivroModel novoLivro)
        {
            LivroServiceResponse<List<LivroModel>> serviceResponse = new LivroServiceResponse<List<LivroModel>>();

            try
            {
                if(novoLivro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados!";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;
                }                

                _context.Add(novoLivro);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Livros.ToList();


            }catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<LivroServiceResponse<List<LivroModel>>> DeleteLivro(int id)
        {
            LivroServiceResponse<List<LivroModel>> serviceResponse = new LivroServiceResponse<List<LivroModel>>();

            try
            {
                LivroModel Livro = _context.Livros.FirstOrDefault(x => x.Id == id);

                if (Livro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Livro não localizado!";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;
                }


                _context.Livros.Remove(Livro);
                await _context.SaveChangesAsync();


                serviceResponse.Dados = _context.Livros.ToList();

            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<LivroServiceResponse<LivroModel>> GetLivroById(int id)
        {
            LivroServiceResponse<LivroModel> serviceResponse = new LivroServiceResponse<LivroModel>();

            try
            {
                LivroModel Livro = _context.Livros.FirstOrDefault(x => x.Id == id);

                if(Livro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Livro não localizado!";
                    serviceResponse.Sucesso = false;
                }

                serviceResponse.Dados = Livro;

            }
            catch(Exception ex)
            {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<LivroServiceResponse<List<LivroModel>>> GetLivros()
        {
            LivroServiceResponse<List<LivroModel>> serviceResponse = new LivroServiceResponse<List<LivroModel>>();

            try
            {
                serviceResponse.Dados = _context.Livros.ToList();

                if(serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                }


            }catch(Exception ex)
            {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;

        }

        public async Task<LivroServiceResponse<List<LivroModel>>> UpdateLivro(LivroModel editadoLivro)
        {
            LivroServiceResponse<List<LivroModel>> serviceResponse = new LivroServiceResponse<List<LivroModel>>();

            try
            {
                LivroModel Livro = _context.Livros.AsNoTracking().FirstOrDefault(x => x.Id == editadoLivro.Id);

                if (Livro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Livro não localizado!";
                    serviceResponse.Sucesso = false;
                }                

                _context.Livros.Update(editadoLivro);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Livros.ToList();

            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }
    }
}
