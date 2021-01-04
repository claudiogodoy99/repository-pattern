# repository-pattern
Repositório do tutorial de como criar um  repository-pattern
# Script do Banco de dados

`CREATE TABLE [dbo].[Cliente] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (255) NOT NULL,
    [Cpf]  VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);`
