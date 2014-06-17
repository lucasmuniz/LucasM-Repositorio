--12)  Liste os nomes de funcionários que começam com a letra ‘M’ ordenados por nome de departamento.

SELECT PrimeiroNome FROM Funcionario as F INNER JOIN Departamento AS D ON F.Departamento_Id=D.Id and F.PrimeiroNome LIKE 'M%' ORDER BY D.Nome;