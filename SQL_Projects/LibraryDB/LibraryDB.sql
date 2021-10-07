create database db_library;

use db_library;

select * from tbl_books;


create table tbl_branch (
	BranchID int primary key not null identity (100, 1),
	BranchName varchar (50) not null,
	"Address" varchar (50) not null
);

create table tbl_borrower (
	CardNo int primary key not null identity (200, 1),
	"Name" varchar(50) not null,
	"Address" varchar(50) not null,
	Phone varchar(50) not null
);

create table tbl_publisher (
	PublisherName varchar(50) primary key not null,
	"Address" varchar(50) not null,
	Phone varchar(50) not null
);

create table tbl_books (
	BookID int primary key not null identity (1, 1),
	Title varchar(50) not null,
	PublisherName varchar(50) foreign key references tbl_publisher(PublisherName)
);

create table tbl_authors (
	BookID int foreign key references tbl_books(BookID) not null identity (1, 1),
	AuthorName varchar(50) not null
);

create table tbl_copies (
	BookID int foreign key references tbl_books(BookID) not null identity (1, 1),
	BranchID int foreign key references tbl_branch(BranchID) not null,
	Number_Of_Copies int not null
);

create table tbl_loans (
	BookID int foreign key references tbl_books(BookID) not null identity (1, 1),
	BranchID int foreign key references tbl_branch(BranchID) not null,
	CardNo int foreign key references tbl_borrower(CardNo) not null,
	DateOut varchar(50) not null,
	DateDue varchar(50) not null
);


insert into tbl_branch(BranchName, "Address")
	values
	('Sharpstown', '23 Cheddar Ave.'),
	('Bloomington', '5 Camambert Ct.'),
	('Softton', '74 Farmers Way'),
	('Hardsville', '286 Pecorino Blvd.'),
	('Creamdale', '89 Schmear St.'),
	('West Crumble', '194 Feta Dr.');

insert into tbl_borrower(CardNo, "Name", "Address", Phone)
	values