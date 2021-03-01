--Drop Sequence for Tables

drop table customers;
drop table orders;
drop table locations;
drop table products;
drop table items;

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
    orderLocationId int not null,
    foreign key (orderLocationId) references locations(locationId),
    orderQuantity1 int not null,
    orderQuantity2 int not null,
    orderQuantity3 int not null,
    orderTotal decimal not null
);

create table locations
(
    locationId int identity primary key,
    streetAddress varchar(100) not null,
    locationName varchar(100) not null,
    locationInventory1 int not null,
    locationInventory2 int not null,
    locationInventory3 int not null 
);
create table products
(
    productName varchar(100) not null,
    price money not NULL
);

insert into products (productName, price) VALUES 
('Soup', $3.50)
insert into products (productName, price) VALUES 
('Spoons', $0.99), ('Bowls', $1.99) 
insert into locations (streetAddress, locationName, locationInventory1, locationInventory2, locationInventory3) VALUES
('1 Road Street', 'Main', 100, 100, 100), ('2 Road Steet', 'Branch', 100, 100, 100);