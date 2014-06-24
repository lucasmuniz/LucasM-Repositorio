--2)	Escreva um comando SQL que retorne os nomes dos alunos e do(s) cursos em que estão matriculados. Os dados deverão estar
--      ordenados pelo nome do curso. 

SELECT TBAluno.Nome,TBCurso.Nome FROM TBAluno INNER JOIN TBCurso ON TBAluno.id=TBCurso.Id ORDER BY TBCurso.Nome