CREATE TABLE [dbo].[ProfessorAluno]
(
	[ProfessorId] INT NOT NULL, 
    [AlunoId] INT NOT NULL, 
	PRIMARY KEY ([ProfessorId], [AlunoId]) ,
    CONSTRAINT [FK_ProfessorAluno_Professor] FOREIGN KEY ([ProfessorId]) REFERENCES [dbo].[Professor]([Id]), 
    CONSTRAINT [FK_ProfessorAluno_Aluno] FOREIGN KEY ([AlunoId]) REFERENCES [dbo].[Aluno]([Id]) 
    
)
