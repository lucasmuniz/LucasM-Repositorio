--14) Liste a quantidade de funcionários de cada departamento.

SELECT D.Nome, COUNT(*) as Quantidade from Funcionario as F inner join Departamento as D on D.Id=F.Departamento_Id group by D.Nome 