--Drop Sequence for Tables

drop table customers;
drop table orders;
drop table locations;

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
    foreign key (orderCustomerId) references customers(customerId),
    orderAddress varchar(100) not null,
    orderLocation varchar(100) not null,

);

create table locations
(
    streetAddress varchar(100) not null,
    locationName varchar(100) not null
);

insert into locations (streetAddress, locationName) VALUES
('1 Road Street', 'Main Location'), ('2 Road Steet', 'Branch Location');