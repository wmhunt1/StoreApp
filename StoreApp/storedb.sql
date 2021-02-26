--Drop Sequence for Tables

drop table customers;
drop table orders;

--creating tables

create table customers
(
    customerId int identity primary key,
    customerName varchar(100) not null,
    customerAddress varchar(100) not null
);

create table orders
(
    orderId int identity primary key,
    orderCustomerId int not null,
    foreign key (orderCustomerId) references customers(customerId)
);