create database MartInventory;
-- drop database MartInventory;
use MartInventory;

create table Product(
pid int primary key auto_increment,
pname varchar(30) not null,
description varchar(40) ,
MRP double(10,2) not null,
Discount double(10,2) ,
Pqty int not null,
Expiry_Date date not null,
ptype varchar(30) not null
);

create table Inventory(
catid int primary key,
catname varchar(30) not null,
plocation varchar(100) not null,
qty int not null
);

create table ProductLocation(
plocation varchar(20) primary key,
pid int not null,
catid int not null,
constraint pid_fk foreign key(pid) references Product(pid),
constraint cid_fk foreign key(catid) references Inventory(catid)
);

create table Shopping_cart(
sid int primary key,
pid int not null,
constraint sc_fk foreign key(pid) references Product(pid)
);

create table Customer(
cid int primary key auto_increment,
cname varchar(100) not null,
cmob decimal(10,0) ,
caddr varchar(100) default "Pune"
);

create table shopping_bill(
bid int primary key auto_increment,
pid int not null,
bill_date date,
gst double(10,2),
constraint bill_fk foreign key(pid) references Product(pid)
);

create table Customer_bill(
bid int,
cid int
);

create table Mart_inventory(
pid int,
cid int ,
plocation varchar(100),
catid int ,
primary key(pid,cid),
constraint cat_fk foreign key(catid) references Inventory(catid),
constraint ploc_fk foreign key(plocation) references ProductLocation(plocation)
);

insert into Product(pid, pname, description, MRP, Discount, Pqty, Expiry_Date, ptype) values(default, 'Wild Stone', 'Long Lasting', 450, 0.0, 1, "2022-07-15", 'Perfume');

