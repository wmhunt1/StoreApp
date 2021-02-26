--Drop Sequence for Tables

drop table customers;
drop table orders;

--creating tables

create table customers
(
    cid int identity primary key,
    customerName varchar(100) not null,
    customerAddress varchar(100) not null
);

create table orders
(
    orderid int identity primary key,
    orderCustomer int unique not null references customers(cid) on delete cascade
);