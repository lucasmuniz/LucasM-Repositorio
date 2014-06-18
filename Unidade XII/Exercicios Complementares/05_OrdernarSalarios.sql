--5) Liste os funcionários que têm salário superior a R$ 1.000,00 ordenados pelo nome completo.
SELECT PrimeiroNome,Salario from Funcionario where salario>1000 Order By PrimeiroNome,SobreNome;