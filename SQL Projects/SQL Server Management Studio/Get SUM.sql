use zoo_test
go

/*	Convert(varchar(50).@totalHab) = This is converting the data type from MONEY to String Characters
	char(9) = Line Break
	char(13) = Tab Key
*/

Declare @totalHab MONEY;
Declare @totalNut MONEY;
Declare @results MONEY;
set @totalHab = (Select SUM(habitat_cost) from habitat);
set @totalNut = (Select SUM(nutrition_cost) from nutrition);
set @results = (@totalHab + @totalNut)
print (
	Convert(varchar(50),@totalHab) + char(9) + ' - The Total Habitat Cost' + char(13) +
	Convert(varchar(50),@totalNut) + char(9) + char(9) + ' - The Total Nutrition Cost' + char(13) + '-------------' + char(13) +
	Convert(varchar(50),@results)
);