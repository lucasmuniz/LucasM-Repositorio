--9) Exclua os departamentos que não tenham funcionários.

DELETE FROM Funcionario where Departamento_Id is null;