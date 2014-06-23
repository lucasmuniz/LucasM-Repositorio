select L.Titulo, l.AnoPublicacao, A.Nome from livro as L,Autor as A --JUNÇÃO DE TABELAS
where A.Id =L.Autor_Id