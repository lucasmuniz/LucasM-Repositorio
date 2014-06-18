-- 18)  Liste o nome do departamento e do funcionário ordenados por departamento e funcionário.

SELECT D.Nome,F.PrimeiroNome from Funcionario as F INNER JOIN Departamento as D ON D.id=F.Departamento_Id order by D.Nome, F.PrimeiroNome