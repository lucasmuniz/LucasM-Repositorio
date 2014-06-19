--5)	Escreva um comando SQL para listar o total de alunos matriculados em cada curso. 

SELECT TBCurso.Nome, COUNT(*)as TotalMatriculados FROM TBCurso INNER JOIN TBMatricula on TBCurso.id=Curso_Id group by Nome