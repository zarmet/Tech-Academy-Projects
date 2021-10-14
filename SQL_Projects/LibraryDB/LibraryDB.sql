create database db_library;

use db_library;

select * from tbl_books;
select *from tbl_borrower;
select *from tbl_branch;
select *from tbl_publisher;
select *from tbl_authors;
select *from tbl_copies;
select *from tbl_loans;

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

insert into tbl_borrower("Name", "Address", Phone)
	values
	('Bruce Parker', '237 Gordon St., Sharpstown', '987-324-5740'),
	('Peter Wayne', '94 Mary Jane Lane, Creamdale', '987-476-1187'),
	('Arthur Marston', '489 B van der Linde Ave., Creamdale', '987-476-4009'),
	('John Morgan', '52 Beecher St., Bloomington', '987-398-2867'),
	('Lucas Harkon', '78 Wolftone Blvd., West Crumble', '805-324-5740'),
	('Jenny Thomson', '15 Tutone St., Softton', '805-867-5309'),
	('Charles Reynolds', '114 Philadelphia Ave., Hardsville', '805-712-5740'),
	('Dennis Kelly', '96 D Patrick St., Hardsville', '805-712-5740');

insert into tbl_publisher (PublisherName, "Address", Phone)
	values
	('Houghton Mifflin', 'Boston, MA', '1-877-234-7323'),
	('Chilton Books', 'Boston, MA', '1-800-354-9706'),
	('Parnassus Press', 'Boston, MA', '1-877-234-7323'),
	('Picador USA', 'New York, NY', '1-800-221-7945'),
	('Faber and Faber', 'London, UK', '44-0-20-7927-3800'),
	('Stoic Studios', 'Austin, TX', 'Email: stoicstudios.com'),
	('Little, Brown Books',  'New York, NY', '1-800-759-0190'),
	('Visionary Publishing Co.', 'Defunct', 'Defunct'),
	('Penguin Classics', 'London, UK', '44-0-20-7139-3000'),
	('Abdul Alhazred', 'Unknown', 'Unknown');

insert into tbl_books (Title, PublisherName)
	values
	('The Hobbit', 'Houghton Mifflin'),
	('The Lord of the Rings', 'Houghton Mifflin'),
	('The Silmarillion', 'Houghton Mifflin'),
	('Dune', 'Chilton Books'),
	('A Wizard of Earthsea', 'Parnassus Press'),
	('The Lost Tribe', 'Picador USA'),
	('The Lord of the Flies', 'Faber and Faber'),
	('The Grapes of Wrath', 'Penguin Classics'),
	('Of Mice and Men', 'Penguin Classics'),
	('The Iliad', 'Penguin Classics'),
	('The Odyssey', 'Penguin Classics'),
	('The Mysterious Benedict Society', 'Little, Brown Books'),
	('The Necronomicon', 'Abdul Alhazred'),
	('Frankenstein', 'Penguin Classics'),
	('Dracula', 'Penguin Classics'),
	('The Shadow over Innsmouth', 'Visionary Publishing Co.'),
	('To Kill a Mockingbird', 'Penguin Classics'),
	('The Gift of Hadrborg', 'Stoic Studios'),
	('Moby Dick', 'Penguin Classics'),
	('Don Quixote', 'Penguin Classics');

insert into tbl_authors (AuthorName)
	values
	('J.R.R. Tolkien'),
	('J.R.R. Tolkien'),
	('J.R.R. Tolkien'),
	('Frank Herbert'),
	('Ursula K. Le Guin'),
	('Mark Lee'),
	('William Golding'),
	('John Steinbeck'),
	('John Steinbeck'),
	('Homer'),
	('Homer'),
	('Trenton Lee Stewart'),
	('Abdul Alhazred'),
	('Mary Shelley'),
	('Bram Stoker'),
	('H.P. Lovecraft'),
	('Harper Lee'),
	('James Fadeley'),
	('Herman Melville'),
	('Miguel de Cervantes');

insert into tbl_copies (BranchID, Number_Of_Copies)
	values
	(100, 4),
	(100, 2),
	(100, 5),
	(104, 3),
	(101, 2),
	(100, 6),
	(100, 2),
	(102, 6),
	(105, 5),
	(102, 2),
	(105, 6),
	(103, 2),
	(105, 2),
	(102, 6),
	(101, 6),
	(104, 6),
	(104, 6),
	(100, 4),
	(101, 2),
	(102, 4);

insert into tbl_loans (BranchID, CardNo, DateOut, DateDue)
	values
	(100, 200, 'Aug. 5', 'Sep. 5'),
	(105, 204, 'Oct. 31', 'Nov. 31'),
	(104, 201, 'Jan. 17', 'Feb. 17'),
	(100, 200, 'Aug. 5', 'Sep. 5'),
	(103, 207, 'Jul. 5', 'Aug. 3'),
	(100, 200, 'Aug. 5', 'Sep. 5'),
	(105, 204, 'Oct. 31', 'Nov. 31'),
	(104, 202, 'Aug. 20', 'Sep. 20'),
	(103, 206, 'Jun. 11', 'Jul. 11'),
	(100, 200, 'Aug. 5', 'Sep. 5'),
	(104, 201, 'Jan. 17', 'Feb. 17'),
	(101, 203, 'Nov. 6', 'Dec. 6'),
	(105, 204, 'Oct. 31', 'Nov. 31'),
	(103, 207, 'Jul. 5', 'Aug. 3'),
	(105, 204, 'Oct. 31', 'Nov. 31'),
	(102, 205, 'May 7', 'Jun. 7'),
	(103, 206, 'Jun. 11', 'Jul. 11'),
	(104, 202, 'Aug. 20', 'Sep. 20'),
	(102, 205, 'May 7', 'Jun. 7'),
	(101, 203, 'Nov. 6', 'Dec. 6');


--QUERIES

select * from ((tbl_loans full outer join tbl_borrower on tbl_loans.CardNo = 
tbl_borrower.CardNo) full outer join tbl_books on tbl_loans.BookID = tbl_books.BookID);

select Title, AuthorName from tbl_books, tbl_authors
where tbl_authors.BookID = tbl_books.BookID;



select Title, BranchName as "Branch Name", Number_Of_Copies as "No. of Copies" from tbl_copies
inner join tbl_books on tbl_copies.BookID = tbl_books.BookID
inner join tbl_branch on tbl_copies.BranchID = tbl_branch.BranchID
where tbl_copies.BookID=6;

select Title, BranchName as "Branch Name", Number_Of_Copies as "No. of Copies" from tbl_copies
inner join tbl_books on tbl_copies.BookID = tbl_books.BookID
inner join tbl_branch on tbl_copies.BranchID = tbl_branch.BranchID
where Title = 'The Lost Tribe';


select "Name", count(tbl_loans.CardNo) as "No. of Books Borrowed" from tbl_loans
inner join tbl_borrower on tbl_loans.CardNo = tbl_borrower.CardNo
group by "Name"
having count(tbl_loans.CardNo)=0;
