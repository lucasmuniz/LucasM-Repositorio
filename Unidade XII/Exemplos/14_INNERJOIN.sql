﻿select L.Titulo, L.AnoPublicacao, A.Nome from livro as L FULL JOIN Autor AS A on A.Id =L.Autor_Id