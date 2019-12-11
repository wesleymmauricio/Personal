CREATE TABLE [dbo].[Curso](
	[CursoId] [int] IDENTITY(1,1) NOT NULL,
	[NomeCurso] [varchar](200) NOT NULL,
	[DataInicio] [datetime] NOT NULL,
	[DataFinal] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastUpdatedBy] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY (CursoId),
 CONSTRAINT [FK_Curso_UserCreated] FOREIGN KEY (CreatedBy) REFERENCES [User](UserId),
 CONSTRAINT [FK_Curso_UserLastUpdated] FOREIGN KEY (LastUpdatedBy) REFERENCES [User](UserId))
