use Library
go

select LB.BranchID, LB.BranchName, sum(BC.NumberOfCopies) as 'Number of Copies'
from LibraryBranch as LB
join BookCopies as BC on LB.BranchID = BC.BranchID
group by LB.BranchID, LB.BranchName;
