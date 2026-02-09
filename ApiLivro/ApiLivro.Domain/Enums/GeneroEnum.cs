using System.Text.Json.Serialization;

namespace ApiLivro.ApiLivro.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GeneroEnum
    {
        Aventura = 1,
        Drama = 2,
        Suspense = 3,
        Romance = 4,
        Biografia = 5,
        Tecnologia = 6,
        Autoajuda = 7,
        Outros = 8
    }
}
