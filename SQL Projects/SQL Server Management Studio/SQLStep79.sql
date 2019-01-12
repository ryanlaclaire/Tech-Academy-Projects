use AdventureWorks2014
go


create procedure dbo.uspGetSpecificPeople
as
select Person.Person.BusinessEntityID, Person.Person.FirstName, Person.Person.LastName, Person.PersonPhone.PhoneNumber, Person.EmailAddress.EmailAddress
from Person.Person
inner join  Person.PersonPhone on Person.Person.BusinessEntityID = Person.PersonPhone.BusinessEntityID
inner join Person.EmailAddress on Person.Person.BusinessEntityID = Person.EmailAddress.BusinessEntityID
where Person.Person.LastName like 'A%' and Person.Person.BusinessEntityID between 5000 and 7000
go
;