create database drills;

use drills
go

create table Employee (
	EmployeeID int primary key not null identity(1, 1),
	FirstName varchar(50) not null,
	LastName varchar(50) not null
);

create table Contact (
	ContactID int primary key not null identity(1, 1),
	Con_Address varchar(100) not null,
	Con_City varchar(50),
	Con_State varchar(20),
	Con_Zip varchar(20),
	Con_Phone varchar(50) not null,
	Con_EmpID int not null constraint fk_EmpID foreign key references Employee(EmployeeID) on update cascade on delete cascade
);

insert  into Employee 
	values
	('Sam', 'Jones'),
	('John', 'McKitrick'),
	('Alice', 'Knight'),
	('Jessica', 'Cervantes'),
	('Matilda', 'Webber')
;

insert into Contact
	values
	('3455 S. Ontario Blvd.', 'Tampa', 'FL', '33601', '324-567-8950', 1),
	('7564 N. Geyser Rd.', 'Tampa', 'FL', '33605', '762-459-9850', 2),
	('324 Thompson Ave.', 'Tampa', 'FL', '33613', '762-324-6785', 3),
	('452 Sycamore Ave.', 'Tampa', 'FL', '33635', '504-544-3945', 4),
	('898 Zenith Cir.', 'Tampa', 'FL', '33635',	'971-344-2454', 5)
;

select Emp.FirstName, Emp.LastName, Contact.Con_Phone
from Employee as Emp
inner join Contact on Emp.EmployeeID = Contact.Con_EmpID
Where Emp.EmployeeID = 3;