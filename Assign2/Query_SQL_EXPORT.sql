create database db_bank;

create table offices(
officeCode int Primary key,
city varchar(50) not null,
addressLine1 varchar(100) not null,
addressLine2 varchar(100),
state varchar(50) not null,
country varchar(50) not null,
postalCode int not null,
territory varchar(50) not null
);

create table employees(
employeeNumber int PRIMARY KEY,
lastName varchar(50) not null,
firstName varchar(50) not null,
extension varchar(50) not null,
email varchar(50),
officeCode int not null,
reportsTo int,
jobTitle varchar(50)
foreign key (reportsTo) references employees(employeeNumber),
foreign key (officeCode) references offices(officeCode)
);

create table customers(
customerNumber int PRIMARY KEY,
customerName varchar(50) not null,
contactLastName varchar(50) not null,
contactFirstName varchar(50) not null,
phone int not null,
addressLine1 varchar(100)not null,
addressLine2 varchar(100) null,
city varchar(50)not null,
state varchar(50)not null,
postalCode int not null,
country varchar(50)not null,
salesRepEmployeeNumber int not null,
creditLimit int not null
foreign key (salesRepEmployeeNumber) references employees(employeeNumber)
);

create table productlines(
productLine varchar(10) PRIMARY KEY,
textDescription varchar(100) not null,
htmlDescription varchar(100) not null,
pimage varbinary
);

create table product(
productCode varchar(10) PRIMARY KEY,
productName varchar(50) not null,
productLine varchar(10) not null,
productScale varchar(20) ,
productVendor varchar(50) not null,
productDescription varchar(100),
quantityInStock int not null,
buyPrice int not null,
MSRP int not null,
foreign key (productLine) references productlines(productLine)
);

create table orders(
orderNumber varchar(10) PRIMARY KEY,
orderData varchar(100) not null,
requiredDate date ,
shippedDate date,
status varchar(20) not null,
comments varchar(100),
customerNumber int not null,
foreign key (customerNumber) references customers(customerNumber)
);

create table ordersdetails(
orderNumber varchar(10) not null,
productCode varchar(10) not null,
quantityOrdered int not null,
priceEach int not null,
orderLineNumber int not null,
foreign key (orderNumber) references orders(orderNumber),
foreign key (productCode) references product(productCode)
);

create table payment(
customerNumber int not null,
checkNumber varchar(10) PRIMARY KEY,
paymentDate date not null,
amount int not null
foreign key (customerNumber) references customers(customerNumber)
);




insert into productlines values
('PL0001','Daging','Makanan enak',null),
('PL0002','Minuman','Minuman enak',null),
('PL0003','Snack','Snack enak',null),
('PL0004','Puding','Puding enak',null),
('PL0005','Es krim','Es krim enak',null),
('PL0006','Nasi','Nasi enak',null),
('PL0007','Sayuran','Sayuran enak',null),
('PL0008','Kopi','Kopi enak',null),
('PL0009','Teh','Teh enak',null),
('PL0010','Gorengan','Gorengan enak',null)
;

insert into product values
('P00001','Bebek Goreng', 'PL0001','', 'ABC','Bebek Goreng', 10, 20000, 18000),
('P00002','Teh olong', 'PL0009','', 'teh','Teh olong', 100, 3000, 3000),
('P00003','Puding Vanilla', 'PL0004','', 'puding indonesia','Puding Vanilla', 50, 5000, 4000),
('P00004','Nasi Putih', 'PL0006','', 'BAC','Nasi Putih', 50, 2000, 2000),
('P00005','Steak Sirloin', 'PL0001','', 'ABC','Steak Sirloin', 30, 50000, 56000),
('P00006','Dadar Jagung', 'PL0001','', 'Warung','Dadar Jagung', 20, 2000, 1500),
('P00007','Es Krim Coklat', 'PL0005','', 'Krim','Es Krim Coklat', 5, 5000, 6000),
('P00008','Es Krim Vannila', 'PL0005','', 'Krim','Es Krim Vannila', 70, 3000, 3000),
('P00009','Kopi Arabika', 'PL0008','', 'kopiiii','Kopi Arabika', 100, 5000, 4800),
('P00010','Puding Coklat', 'PL0004','', 'puding indonesia','Puding Coklat', 180, 5000, 4000);

insert into offices values
(0001,'Surabaya',123456789, 'Surabaya Barat', 'Indonesia','Jawa Timur',60155,'Barat'),
(0002,'Surabaya',234567891, 'Surabaya Timur', 'Indonesia','Jawa Timur',60150,'Timur'),
(0003,'Jakarta',345678912, 'Jakarta Barat', 'Indonesia','Jakarta',62151,'Barat'),
(0004,'Jakarta',456789123, 'Jakarta Timur', 'Indonesia','Jakarta',62152,'Timur'),
(0005,'Bandung',567891234, 'Bandung Barat', 'Indonesia','Jawa Barat',60111,'Barat'),
(0006,'Bandung',678912345, 'Bandung Timur', 'Indonesia','Jawa Barat',60110,'Timur'),
(0007,'Solo',789123456, 'Solo', 'Indonesia','Jawa Tengah',65456,''),
(0008,'Madiun',891234567, 'Madiun', 'Indonesia','Jawa Timur',66512,''),
(0009,'Banyuwangi',912345678, 'Banyuwangi', 'Indonesia','Jawa Timur',67123,''),
(0010,'Probolinggo',234567899, 'Probolinggo', 'Indonesia','Jawa Timur',69125,'');


insert into employees values
(0001,'Suryatmi', 'Mila','','mila@gmail.com',0010,null,'Menerima report dari sales'),
(0002,'Kuswoyo', 'Hasim','','Hasim@gmail.com',0010,0001,'Sales'),
(0003,'Anggraini', 'Ami','','Ami@gmail.com',0010,0001,'Sales'),
(0004,'Hidayanto', 'Rosman','','Rosman@gmail.com',0001,null,'Menerima report dari sales'),
(0005,'Sitorus', 'Lukman','','Lukman@gmail.com',0002,null,'Menerima report dari sales'),
(0006,'Haryanti', 'Hafshah','','Hafshah@gmail.com',0001,0004,'sales'),
(0007,'Mangunsong', 'Waluyo','','Waluyo@gmail.com',0002,0005,'sales'),
(0008,'Namaga', 'Ifa','','Ifa@gmail.com',0003,0008,'Menerima report dari sales & Sales'),
(0009,'Widiastuti', 'Kania','','Kania@gmail.com',0005,0009,'Menerima report dari sales & Sales'),
(0010,'Pradipta', 'Bagus','','Bagus@gmail.com',0009,0010,'Menerima report dari sales & Sales');


insert into customers values
(000001,'Ira Purwanti','Purwanti','Ira', '987654321','Surabaya', null, 'Surabaya' , 'Timur', 60150, 'Indonesia', 0004, 50000 ),
(000002,'Digdaya Hardiansyah','Hardiansyah','Digdaya', '876543219','Jakarta', null, 'Jakarta' , 'Barat', 62151, 'Indonesia', 0008, 150000 ),
(000003,'Balijan Zulkarnain','Zulkarnain','Balijan', '765432198','Probolinggo', null, 'Probolinggo' , '', 69125, 'Indonesia', 0002, 20000 ),
(000004,'Hasta Natsir','Natsir','Hasta', '654321987','Surabaya', null, 'Surabaya' , 'Barat', 60155, 'Indonesia', 0006, 125000 ),
(000005,'Zamira Farida','Farida','Zamira', '543219876','Banyuwangi', null, 'Banyuwangi' , '', 67123, 'Indonesia', 0010, 55000 ),
(000006,'Akarsana Wasita','Wasita','Akarsana', '432198765','Jakarta', null, 'Jakarta' , 'Barat', 62151, 'Indonesia', 0008, 60000 ),
(000007,'Arsipatra Irawan','Irawan','Arsipatra', '321987654','Jakarta', null, 'Jakarta' , 'Barat', 62151, 'Indonesia', 0008, 150000 ),
(000008,'Keisha Agustina','Agustina','Keisha', '219876543','Probolinggo', null, 'Probolinggo' , '', 69125, 'Indonesia', 0002, 300000 ),
(000009,'Baktiadi Nababan','Nababan','Baktiadi', '198765432','Surabaya', null, 'Surabaya' , 'Timur', 60150, 'Indonesia', 0006, 500000 ),
(000010,'Cindy Wastuti','Wastuti','Cindy', '119876543','Surabaya', null, 'Surabaya' , 'Timur', 60150, 'Indonesia', 0008, 700000 );

insert into payment values
(000001,'CN000001', '2021-01-01', 150000),
(000002,'CN000002', '2021-03-29', 30000),
(000003,'CN000003', '2021-01-24', 500000),
(000004,'CN000004', '2021-11-21', 800000),
(000005,'CN000005', '2021-01-10', 90000),
(000006,'CN000006', '2021-02-05', 50000),
(000007,'CN000007', '2021-05-25', 10000),
(000008,'CN000008', '2021-06-21', 50000),
(000009,'CN000009', '2021-07-11', 1500000),
(000010,'CN000010', '2021-09-01', 200000);

insert into orders values
('O00000001', '','2021-01-01','2021-01-01','Done','',000001),
('O00000002', '','2021-04-15','2021-04-17','Done','',000002),
('O00000003', '','2021-05-14','2021-05-16','Done','',000003),
('O00000004', '','2021-06-26','2021-06-28','Done','',000004),
('O00000005', '','2021-05-18','2021-05-20','Done','',000005),
('O00000006', '','2021-11-01','2021-11-30','Pending','',000006),
('O00000007', '','2021-11-01','2021-11-29','Pending','',000007),
('O00000008', '','2021-11-01','2021-11-29','Pending','',000008),
('O00000009', '','2021-11-01','2021-11-30','Pending','',000009),
('O00000010', '','2021-11-01','2021-11-30','Pending','',000001);

insert into ordersdetails values
('O00000001', 'P00001',10,25000,1),
('O00000002', 'P00002',10,5000,1),
('O00000003', 'P00010',10,10000,1),
('O00000004', 'P00010',16,10000,1),
('O00000005', 'P00003',15,10000,1),
('O00000006', 'P00009',20,8000,1),
('O00000007', 'P00004',5,25000,1),
('O00000008', 'P00005',3,80000,1),
('O00000009', 'P00005',4,80000,1),
('O00000010', 'P00005',5,80000,1);


