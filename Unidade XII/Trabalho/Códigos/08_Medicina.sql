 --8)	Faça um comando SQL que retorne o nome de todas as mulheres matriculadas no curso de Medicina. 
 Select * from tbMatricula AS mat inner join tbCurso AS c ON c.Id = mat.Curso_Id inner join tbAluno as a ON a.Id = mat.Aluno_Id WHERE 
 mat.Curso_Id = 1 and a.Sexo = 'F';