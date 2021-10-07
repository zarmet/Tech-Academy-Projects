/*CHALLENGE 7*/
create database db_giants;

use db_giants;

create table tbl_common (
	giant_id int primary key identity (1, 1) not null,
	giant_type varchar (50) not null,
	CR varchar(3) not null
);

CREATE TABLE tbl_giant (
	giant_key int FOREIGN KEY REFERENCES tbl_common(giant_id) identity (1, 1) not null,
    giant_name varchar(50) NOT NULL,
	alignment varchar(10) not null 
);

insert into tbl_common(giant_type, CR)
values
('Storm Giant', '13'),
('Cloud Giant', '9'),
('Fire Giant', '9'),
('Frost Giant', '8'),
('Stone Giant', '7'),
('Hill Giant', '5');

insert into tbl_giant(giant_name, alignment)
	values
	('Uvarjotun', 'CG'),
	('Skyejotun', 'NG or NE'),
	('Ildjotun', 'LE'),
	('Isejotun', 'NE'),
	('Steinjotun', 'N'),
	('Haugjotun', 'CE');

select*from tbl_common;
select*from tbl_giant;

drop table tbl_giant;
drop table tbl_common;


select
	a1.giant_type as "Giant", a1.CR,
	a2.alignment as "Alignment"
	from tbl_common a1
	join tbl_giant a2 on a2.giant_key=a1.giant_id
	where giant_type = 'Storm Giant';