
# Projeto ApiLivro

Este projeto utiliza **Entity Framework Core** para gerenciar o banco de dados via migrations.

---

## Configuração da Connection String

No arquivo `appsettings.json`, existe uma seção chamada `ConnectionStrings`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=LivrosBD;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true"
}


-- Autenticação do Windows

Trusted_Connection=True significa que o EF Core tentará usar o usuário do Windows atual para se conectar ao SQL Server.


-- Autenticação SQL (usuário e senha)

Se o servidor não usar autenticação do Windows, ajuste a connection string para incluir usuário e senha:

"ConnectionStrings": {
  "DefaultConnection": "Server=SERVIDOR_SQL;Database=LivrosBD;User Id=usuario;Password=senha;Encrypt=false;TrustServerCertificate=true"
}


Substitua: SERVIDOR_SQL pelo nome ou endereço do seu servidor SQL e usuario e senha pelas credenciais fornecidas pela empresa.


---


### Aplicando as Migrations

Depois de configurar a connection string corretamente, siga os passos:


-- Usando Visual Studio (Package Manager Console)

Abra o Package Manager Console em:

Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes

Execute: Update-Database


-- Usando Terminal (VS Code ou Prompt de Comando)

Abra o terminal na pasta do projeto

Execute: dotnet ef database update


Isso cria o banco de dados (se não existir) e aplica as migrations, gerando as tabelas conforme os modelos definidos.
