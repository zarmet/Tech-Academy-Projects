USE db_zoo;

CREATE TABLE tbl_animalia (
	animalia_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	animalia_type VARCHAR(50) NOT NULL
);

INSERT INTO tbl_animalia (animalia_type)
	VALUES ('vertebrate'), ('invertebrate')
;

SELECT * FROM tbl_animalia;


CREATE TABLE tbl_class (
	class_id INT PRIMARY KEY NOT NULL IDENTITY (100,1),
	class_type VARCHAR(50) NOT NULL
);


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

SELECT * FROM tbl_class;

CREATE TABLE tbl_order (
	order_id INT PRIMARY KEY NOT NULL IDENTITY (100,1),
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

INSERT INTO tbl_order (order_type)
	VALUES
	('carnivore'),
	('omnivore'),
	('herbivore')
;

Select * From tbl_order;

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

select * from tbl_care


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

select * from tbl_nutrition;

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

select * from tbl_habitat;

insert into tbl_specialist (specialist_fname, specialist_lname, specialist_contact)
	values
	('margaret', 'nguyen', '384-576-2899'),
	('mary', 'fischer', '384-784-4856'),
	('arnold', 'holden', '385-475-3944'),
	('kem', 'byesan', '384-485-4855'),
	('delmonte', 'fyedo', '768-288-3749')
;

select * from tbl_specialist;