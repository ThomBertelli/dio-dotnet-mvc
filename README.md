# Projeto de Estudo - Agenda de Contatos (MVC)

Este projeto foi desenvolvido como parte do curso **.NET Developer** da **[Digital Innovation One (DIO)](https://www.dio.me/)**, no módulo **MVC**. Trata-se de uma aplicação ASP.NET Core MVC para gerenciar uma agenda de contatos, com funcionalidades básicas de CRUD (Create, Read, Update, Delete).

## Objetivo

O objetivo deste projeto é consolidar os conhecimentos adquiridos no módulo de **MVC** do curso, aplicando conceitos como:

- Estrutura do padrão MVC (Model-View-Controller).
- Configuração e uso do Entity Framework Core.
- Criação de rotas e controllers.
- Desenvolvimento de views utilizando Razor.
- Integração com banco de dados SQL Server.

## Funcionalidades

- **Listar Contatos**: Exibe uma lista de contatos cadastrados.
- **Criar Contato**: Permite adicionar um novo contato.
- **Editar Contato**: Permite editar as informações de um contato existente.
- **Excluir Contato**: Permite remover um contato da lista.

## Tecnologias Utilizadas

- **ASP.NET Core MVC**: Framework para desenvolvimento web.
- **Entity Framework Core**: ORM para manipulação de dados.
- **SQL Server**: Banco de dados utilizado para persistência.
- **Bootstrap**: Framework CSS para estilização.

## Estrutura do Projeto

O projeto segue a estrutura padrão do ASP.NET Core MVC:

```
├── Context/
│   └── AgendaContext.cs
├── Controllers/
│   ├── ContatoController.cs
│   └── HomeController.cs
├── Migrations/
├── Models/
│   ├── Contato.cs
│   └── ErrorViewModel.cs
├── Views/
│   ├── Contato/
│   │   ├── Criar.cshtml
│   │   ├── Index.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── Error.cshtml
│   └── Home/
│       ├── Index.cshtml
│       ├── Privacy.cshtml
├── Program.cs
├── appsettings.Development.json
└── appsettings.json
```

## Configuração do Ambiente

1. Certifique-se de ter o **.NET SDK 9.0** ou superior instalado.
2. Configure a string de conexão com o banco de dados no arquivo `appsettings.Development.json`:
   ```json
   "ConnectionStrings": {
     "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=AgendaMvc; Integrated Security=True; TrustServerCertificate=True"
   }
   ```
3. Execute as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```
4. Inicie o projeto:
   ```bash
   dotnet run
   ```

## Como Usar

1. Acesse a aplicação no navegador em `https://localhost:5001`.
2. Utilize as funcionalidades disponíveis para gerenciar os contatos:
   - Clique em **Novo Contato** para adicionar um novo contato.
   - Utilize as opções **Editar**, **Detalhes** e **Deletar** para gerenciar os contatos existentes.

## Observações

Este projeto foi desenvolvido exclusivamente para fins de estudo e aprendizado, como parte do curso **.NET Developer** da **DIO**. Não deve ser utilizado em produção.

---
