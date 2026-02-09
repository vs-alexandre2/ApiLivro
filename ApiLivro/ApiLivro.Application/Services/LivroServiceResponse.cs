namespace ApiLivro.ApiLivro.Application.Services
{
    public class LivroServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
