create database MartInventory;

use MartInventory;

create table Product{
pid int primary key auto_increment,
pname varchar(30) not null,
description varchar(40) not null,
MRP double(10,2) not null,
Discount double(10,2) not null,
Pqty int not null,
Expiry_Date date not null,
ptype varchar(30) not null
}

create table ProductLoaction{
pid int not null,
plocation varchar(20) primary key,
catid int not null
}

create table Shopping_cart{
sid int primary key,
pid int not null,
constraint sc_fk foreign key(pid) references Product(pid),
}

create table Inventory{
catid int primary key,
catname varchar(30) not null,
plocation (key unknown),
qty int not null
}

create table billing_shopping{
bid int primary key auto_increment,
pid int,
bill_date date,
gst double(10,2)
}

create table Billing_cust{
bid int,
cid int
}