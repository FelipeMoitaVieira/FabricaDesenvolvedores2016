CREATE TABLE [dbo].[Endereco]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Bairro] VARCHAR(50) NOT NULL, 
    [Cidade] VARCHAR(100) NOT NULL, 
    [Cep] VARCHAR(8) NOT NULL, 
    [Logradouro] VARCHAR(150) NOT NULL, 
    [NomeEstado] VARCHAR(100) NOT NULL, 
    [Estado] VARCHAR(2) NOT NULL
)
