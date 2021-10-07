use db_zoo1;

SELECT * FROM tbl_animalia;
SELECT * FROM tbl_class;
Select * From tbl_order;
select * from tbl_care;
select * from tbl_nutrition;
select * from tbl_habitat;
select * from tbl_specialist;
select*from tbl_species;


/*CHALLENGE 1*/
select *from tbl_habitat;

/*CHALLENGE 2*/
select species_name
from tbl_species
where species_order=3;

/*CHALLENGE 3*/
select nutrition_type
from tbl_nutrition
where nutrition_cost<=600;

/*CHALLENGE 4*/
select species_name
from tbl_species
where species_nutrition < 2206 and species_nutrition > 2202;

/*CHALLENGE 5*/
select
	a1.species_name as "Species Name:",
	a2.nutrition_type as "Nutrition Type:"
	from tbl_species a1
	inner join tbl_nutrition a2 on a2.nutrition_id = a1.species_nutrition
;

/*CHALLENGE 6*/
select
	a1.species_name as "Animal:", a2.care_specialist as "Specialist ID",
	a3.specialist_fname as "First Name", a3.specialist_lname as "Last Name", a3.specialist_contact as "Contact"
	from tbl_species a1
	join tbl_care a2 on a2.care_id = a1.species_care
	join tbl_specialist a3 on a3.specialist_id= a2.care_specialist
	where species_name = 'penguin';
