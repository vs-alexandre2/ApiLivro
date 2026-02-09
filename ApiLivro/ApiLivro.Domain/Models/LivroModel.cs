using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiLivro.ApiLivro.Domain.Enums;

namespace ApiLivro.ApiLivro.Domain.Models
{
    public class LivroModel
    {
        [Key]
        public int Id { get; set; }
        public string Livro { get; set; }
        public string Autor { get; set; }
        public GeneroEnum Genero { get; set; }        
    } 
}
