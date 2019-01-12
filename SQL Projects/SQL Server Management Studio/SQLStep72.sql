use db_zoo
go

select spec.specialist_fname, spec.specialist_lname, spec.specialist_contact
from tbl_specialist as spec
inner join tbl_care on spec.specialist_id = tbl_care.care_specialist
inner join tbl_species on tbl_care.care_id = tbl_species.species_care
where tbl_species.species_name = 'penguin'
; 