use AdventureWorks2017;


select*from HumanResources.EmployeePayHistory;

--SELECT DISTINCT CHALLENGE
select distinct CountryRegionCode, CurrencyCode
from Sales.CountryRegionCurrency;

--SELECT TOP CHALLENGE
select top 20 percent CurrencyCode
from Sales.CountryRegionCurrency
;

--MIN/MAX CHALLENGE
select min(Rate) as "Lowest Salary"
from HumanResources.EmployeePayHistory;

select max(Rate) as "Highest Salary"
from HumanResources.EmployeePayHistory;

--LIKE CHALLENGE
select * from 
Sales.CountryRegionCurrency
where CurrencyCode like 'E%';

--WILDCARD CHALLENGE
select * from 
Sales.CountryRegionCurrency
where CurrencyCode like '[au]sd';

--BETWEEN CHALLENGE
select CurrencyCode 
from Sales.CountryRegionCurrency
where CurrencyCode between 'K' and 'P';