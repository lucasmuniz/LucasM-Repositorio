--8) Liste o valor da folha de pagamento de cada departamento.
SELECT D.Nome,SUM (F.Salario)as Folha FROM Departamento as D inner join Funcionario as F
on  F.Departamento_Id=D.Id group by D.Nome

