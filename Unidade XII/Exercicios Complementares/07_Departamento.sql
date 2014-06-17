SELECT F.PrimeiroNome,F.Funcao,D.Nome FROM Funcionario as F inner join Departamento as D
on F.Departamento_Id=D.Id order by PrimeiroNome;

--7) Liste o nome, o nome do departamento e a função de todos os funcionários ordenado por nome.

