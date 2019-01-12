use db_zoo
go

select spec.species_name as [Species Name], nut.nutrition_type as [Nutrition Type]
from tbl_species as spec, tbl_nutrition as nut
where spec.species_nutrition = nut.nutrition_id
;