create database db_zoo1
go

use db_zoo1;

create proc createZooDB
as
begin
	CREATE TABLE tbl_animalia (
	animalia_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	animalia_type VARCHAR(50) NOT NULL
);

	CREATE TABLE tbl_class (
		class_id INT PRIMARY KEY NOT NULL IDENTITY (100,1),
		class_type VARCHAR(50) NOT NULL
	);

	CREATE TABLE tbl_order (
		order_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
		order_type VARCHAR(50) NOT NULL
	);

	CREATE TABLE tbl_care (
		care_id VARCHAR(50) PRIMARY KEY NOT NULL,
		care_type VARCHAR(50) NOT NULL,
		care_specialist INT NOT NULL
	);

	CREATE TABLE tbl_nutrition (
		nutrition_id INT PRIMARY KEY NOT NULL IDENTITY (2200,1),
		nutrition_type VARCHAR(50) NOT NULL,
		nutrition_cost MONEY NOT NULL
	);

	CREATE TABLE tbl_habitat (
		habitat_id INT PRIMARY KEY NOT NULL IDENTITY (5000,1),
		habitat_type VARCHAR(50) NOT NULL,
		habitat_cost MONEY NOT NULL
	);

	CREATE TABLE tbl_specialist (
		specialist_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
		specialist_fname VARCHAR(50) NOT NULL,
		specialist_lname VARCHAR(50) NOT NULL,
		specialist_contact VARCHAR(50) NOT NULL
	);

	create table tbl_species (
		species_id int primary key not null identity (1, 1),
		species_name varchar(50) not null,
		species_animalia int not null constraint fk_animalia_id foreign key references tbl_animalia(animalia_id) on update cascade on delete cascade,
		species_class int not null constraint fk_class_id foreign key references tbl_class(class_id) on update cascade on delete cascade,
		species_order int not null constraint fk_order_id foreign key references tbl_order(order_id) on update cascade on delete cascade,
		species_habitat int not null constraint fk_habitat_id foreign key references tbl_habitat(habitat_id) on update cascade on delete cascade,
		species_nutrition int not null constraint fk_nutrition_id foreign key references tbl_nutrition(nutrition_id) on update cascade on delete cascade,
		species_care varchar(50) not null constraint fk_care_id foreign key references tbl_care(care_id) on update cascade on delete cascade
	);

	INSERT INTO tbl_animalia (animalia_type)
		VALUES ('vertebrate'), ('invertebrate')
	;

	INSERT INTO tbl_class (class_type)
		VALUES
		('bird'),
		('reptilian'),
		('mammal'),
		('arthropod'),
		('fish'),
		('worm'),
		('cnidaria'),
		('echinoderm')
	;

	INSERT INTO tbl_order (order_type)
		VALUES
		('carnivore'),
		('omnivore'),
		('herbivore')
	;

	Insert into tbl_care (care_id, care_type, care_specialist)
		values
		('care_0', 'replace the straw', 1),
		('care_1', 'repair broken toys', 4),
		('care_2', 'bottle feed vitamins', 1),
		('care_3', 'play with the animal', 2),
		('care_4', 'clean up waste', 1),
		('care_5', 'move animal to exercise pen', 3),
		('care_6', 'drain and refill aquarium', 1),
		('care_7', 'dental work', 3)
	;

	insert into tbl_nutrition (nutrition_type, nutrition_cost)
		values
		('raw fish', 1500),
		('live rodents', 600),
		('fruits and grain', 800),
		('milk', 600),
		('syringe feed broth', 600),
		('seed and suet', 400),
		('aphids', 150),
		('vitamins and marrow', 3500)
	;

	insert into tbl_habitat (habitat_type, habitat_cost)
		values
		('tundra', 40000),
		('bosky knoll', 12000),
		('pond and rocks', 30000),
		('arctic aquarium', 50000),
		('shaded grassland with water', 50000),
		('netted forest', 10000),
		('viney jungle', 15000),
		('cliffside caves', 15000)
	;

	insert into tbl_specialist (specialist_fname, specialist_lname, specialist_contact)
		values
		('margaret', 'nguyen', '384-576-2899'),
		('mary', 'fischer', '384-784-4856'),
		('arnold', 'holden', '385-475-3944'),
		('kem', 'byesan', '384-485-4855'),
		('delmonte', 'fyedo', '768-288-3749')
	;

	insert into tbl_species
	(species_name, species_animalia, species_class, species_order, species_habitat, species_nutrition, species_care)
		values
		('brown bear', 1, 102, 3, 5007, 2200, 'care_1'),
		('jaguar', 1, 102, 1, 5007, 2200, 'care_4'),
		('penguin', 1, 100, 1, 5003, 2200, 'care_6'),
		('ghost bat', 1, 102, 1, 5007, 2204, 'care_2'),
		('chicken', 1, 100, 3, 5001, 2205, 'care_0'),
		('panda', 1, 102, 3, 5006, 2202, 'care_4'),
		('bobcat', 1, 102, 1, 5001, 2204, 'care_5'),
		('grey wolf', 1, 102, 1, 5000, 2201, 'care_4')
	;

	select*from tbl_species;
	select
	a1.species_name, a2.animalia_type,
	a3.class_type, a4.order_type,
	a5.habitat_type, a6.nutrition_type,
	a7.care_type
	from tbl_species a1
	inner join tbl_animalia a2 on a2.animalia_id = a1.species_animalia
	inner join tbl_class a3 on a3.class_id = a1.species_class
	inner join tbl_order a4 on a4.order_id = a1.species_order
	inner join tbl_habitat a5 on a5.habitat_id =a1.species_nutrition
	inner join tbl_nutrition a6 on a6.nutrition_id = a1.species_nutrition
	inner join tbl_care a7 on a7.care_id = a1.species_care
	where species_name = 'ghost bat'
;
end

execute [dbo].[createZooDB]