
# Projeto ApiLivro

Este projeto é uma API para cadastro de livros, desenvolvida em **ASP.NET Core**, utilizando **Entity Framework Core** e **SQL Server**. 


A conexão com o banco de dados é configurada no arquivo `appsettings.json`, na seção `ConnectionStrings`. A configuração padrão é:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=LivrosBD;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true"
}

**Autenticação do Windows:** `Trusted_Connection=True` indica que o EF Core tentará usar o usuário atual do Windows para se conectar ao SQL Server. 


**Autenticação com usuário e senha:** Também é possível configurar a conexão com usuário e senha:

"ConnectionStrings": {
  "DefaultConnection": "Server=SERVIDOR_SQL;Database=LivrosBD;User Id=usuario;Password=senha;Encrypt=false;TrustServerCertificate=true"
}

Substitua `SERVIDOR_SQL` pelo nome do servidor SQL e `usuario` e `senha` pelas credenciais fornecidas pela empresa. 



**Aplicando as migrations:** 

No **Visual Studio**, abra o **Package Manager Console** em `Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes` e execute:

Update-Database



(Ou se preferir) No **VS Code** ou **Prompt de Comando**, abra o terminal na pasta do projeto e execute:

dotnet ef database update


Isso criará o banco de dados (se ainda não existir) e aplicará as migrations, gerando automaticamente as tabelas conforme os modelos definidos no projeto.



