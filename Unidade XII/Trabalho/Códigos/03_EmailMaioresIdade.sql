--3)Crie um comando SQL que retorne o e-mail de todos os alunos maiores de idade. 

SELECT Email FROM TBAluno WHERE DataNascimento <= '1996-06-24'

--SELECT Email,(DATEDIFF(YEAR,DataNascimento,GETDATE())) FROM TBAluno WHERE (DATEDIFF(YEAR,DataNascimento,GETDATE())) >17