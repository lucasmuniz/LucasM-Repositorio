SET IDENTITY_INSERT [dbo].[Aluno] ON
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Telefone], [Altura], [Aprovado], [Email]) VALUES (1, N'Lucas', 99520610, 1.9, N'Aprovado', N'lucas_goedert@hotmail.com')
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Telefone], [Altura], [Aprovado], [Email]) VALUES (2, N'Giorgi', 99566459, 1.95, N'Reprovado', N'giorgi@hotmail.com')
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Telefone], [Altura], [Aprovado], [Email]) VALUES (3, N'Camila', 88555554, 1.8, N'Reprovado', N'camila@hotmail.com')
SET IDENTITY_INSERT [dbo].[Aluno] OFF
