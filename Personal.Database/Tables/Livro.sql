CREATE TABLE [dbo].[Livro](
	[LivroId] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](200) NOT NULL,
	[Editora] [varchar](200) NOT NULL,
	[Escritor] [varchar](200) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[LastUpdatedBy] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Livro] PRIMARY KEY (LivroId),
 CONSTRAINT [FK_Livro_UserCreated] FOREIGN KEY (CreatedBy) REFERENCES [User](UserId),
 CONSTRAINT [FK_Livro_UserLastUpdated] FOREIGN KEY (LastUpdatedBy) REFERENCES [User](UserId))
