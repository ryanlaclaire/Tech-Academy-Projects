use db_zoo
go

select species_name from tbl_species
inner join tbl_nutrition on tbl_species.species_nutrition = tbl_nutrition.nutrition_id
	where nutrition_id between 2202 and 2206
;