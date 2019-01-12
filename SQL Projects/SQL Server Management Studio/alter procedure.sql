use zoo_test
go

set ansi_nulls on
go
set quoted_identifier on
go

alter procedure [dbo].[getAnimalInfo]

@animalName varchar(50)
as
begin
	declare @errorString varchar(100)
	declare @results varchar(50)
	set @errorString = 'There are no '+@animalName+'''s found at this zoo.'

	begin try
		set @results = (select count(species.species_name) from species where species_name = @animalName)
			if @results = 0
				begin
					raiserror(@errorString, 16, 1)
					return
				end
			else if @results >= 1
				begin
					select
						a1.species_name, a2.animalia_type, a3.class_type, a4.order_type,
						a5.habitat_type, a6.nutrition_type, a7.care_type
						from species a1
						inner join animalia a2 on a2.animalia_id = a1.species_animalia
						inner join class a3 on a3.class_id = a1.species_class
						inner join mainorder a4 on a4.order_id = a1.species_order
						inner join habitat a5 on a5.habitat_id = a1.species_habitat
						inner join nutrition a6 on a6.nutrition_id = a1.species_nutrition
						inner join care a7 on a7.care_id = a1.species_care
						where a1.species_name = @animalName
					;
				end
	end try

	begin catch
		select @errorString = ERROR_MESSAGE()
		raiserror (@errorString, 10, 1)
	end catch
end