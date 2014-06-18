-- 17)  Liste o maior salário pago pela empresa em cada departamento.

SELECT D.Nome, MAX(F.Salario) AS MaiorSalario from Funcionario as F INNER JOIN Departamento as D ON D.Id=F.Departamento_Id group by D.Nome 