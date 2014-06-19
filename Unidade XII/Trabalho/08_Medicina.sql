 --8)	Faça um comando SQL que retorne o nome de todas as mulheres matriculadas no curso de Medicina. 
 Select a.Nome AS Nome, c.Nome as Curso from tbMatricula as mat INNER JOIN tbCurso AS c on c.id = mat.Curso_Id INNER JOIN
  tbAluno as a ON a.Id = mat.Aluno_Id where c.Nome = 'Medicina%' AND a.Sexo = 'F';