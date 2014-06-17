--10)  Liste os departamentos dos funcionários que têm a função de supervisor.

SELECT DISTINCT D.Nome FROM Funcionario as F inner Join Departamento AS D on F.Departamento_Id=D.Id AND F.Funcao='Supervisor'