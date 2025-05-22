API sobre estado civil

Descrição: Este é um projeto de uma Web API para gerenciar informações de pessoas como nome, idade e o estado civil, incluindo camadas de Negócio, Dados e Modelos. 
A API fornece funcionalidades para criar, ler, atualizar e deletar informações de pessoas.


Tecnologias Usadas:
 - .NET 9
   
 - ASP.NET Core Web API

 - Entity Framework Core (para acesso a dados)

 - SQL Oracle

   
O projeto possui as seguintes camadas:

 - Pessoas (Web API): A camada de apresentação da API, que expõe os endpoints REST.

 - PessoasBusiness: Contém as regras de negócio e lógica do sistema.

 - PessoasData: Gerencia o acesso e manipulação dos dados (camada de dados).

 - PessoasModel: Contém as entidades e modelos usados em todo o sistema.


Pré-Requisitos:
Antes de rodar o projeto, você precisa ter os seguintes programas instalados:

 - .NET SDK (versão 9): Instalar .NET

 - SQL Oracle

 - Visual Studio ou VS Code (com suporte a C#)


Instalação:

  ```bash 
  - git clone https://github.com/Maciel0123/CP_3_.NET.git
  - cd CP_3_.NET
  - dotnet restore
  - dotnet ef database update
  - dotnet run --project Pessoas/Pessoas.csproj
   ```


Endpoints disponiveis na API:

 - GET /api/pessoas: Retorna a lista de todas as pessoas.

 - GET /api/pessoas/{id}: Retorna uma pessoa pelo ID.

 - POST /api/pessoas: Cria uma nova pessoa.

 - PUT /api/pessoas/{id}: Atualiza uma pessoa existente.

 - DELETE /api/pessoas/{id}: Deleta uma pessoa pelo ID.

Contato:
 - Autor: Henrique Maciel
 - Email: mrmmjs70@gmial.com
