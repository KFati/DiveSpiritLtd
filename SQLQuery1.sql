Create table Employee
( EmployeeId int not null,
  EmpFname varchar(max) not null,
  EmpLname varchar(max) not null,
  EmpAddress varchar(max) not null,
  gender varchar(max) not null,
  position varchar(max) not null,
  primary key (EmployeeId) );

  Create table Customer
 ( CustomerId int not null,
   EmployeeId int not null,
   CustomerFname varchar(max) not null,
   CustomerLname varchar(max) not null,
   gender varchar(max) not null,
   CustomerAddress varchar(max) not null,
   MedicalStatement varchar(max) not null,
   DiveInsuranceNum int not null,
   DiverLevel varchar(max) not null,
   EmailAddress varchar(max) not null,
   PhoneNum int not null,
   primary key (CustomerId),
   foreign key (EmployeeId) references Employee(EmployeeId) );

   Create table Inventory
( ItemId varchar(10) not null,
  ItemName varchar(max) not null,
  size varchar(max),
  NumInStock int not null,
  Price decimal not null,
  primary key (ItemId) );

  Create table Booking
( BookingId int not null,
  CustomerId int,
  EmployeeId int,
  DiveName varchar(50),
  CourseName varchar (50),
  primary key (BookingId),
  foreign key (CustomerId) references Customer(CustomerId),
  foreign key (EmployeeId) references Employee(EmployeeId) );

  Create table payment
( AccountNumber bigint not null,
BookingId int,
CustomerId int,
EmployeeId int not null,
NumberOfDives int,
DivePrice varchar(max),
CoursePrice varchar(max),
ProductPrice varchar(max),
PaymentMethod varchar(max),
TotalAmount float,
primary key (AccountNumber),
foreign key (CustomerId) references Customer(CustomerId),
foreign key (EmployeeId) references Employee(EmployeeId),
foreign key (BookingId) references booking(BookingId) );

Create table users
( Username varchar(max) not null,
  Passwords varchar(max) not null,
  UserType varchar(max) not null );

  create table payroll
( EmployeeId int,
  HoursWorked int,
  Amount float,
  foreign key (EmployeeId) references Employee(EmployeeId) );

Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0101, 'Thierry', 'Marie-Jeanne', 'Trou Aux Biches', 'Male', 'Manager');
Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0202, 'Charlene', 'Stenton-Dozey', 'Trou Aux Biches', 'Female', 'PADI Instructor');
Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0303, 'Pascal', 'Maurer', 'Grand Baie', 'Male', 'SSI Instructor');
Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0404, 'Bruno', 'Michaud', 'Trou Aux Biches', 'Male', 'Skipper');
Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0505, 'Cedrick', 'Fine', 'Grand Baie', 'Male', 'PADI Instructor');
Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0606, 'Noah', 'Marie-Jeanne', 'Trou Aux Biches', 'Male', 'Skipper');
Insert into Employee (EmployeeId,EmpFname,EmpLname,EmpAddress,gender,position) values (0707, 'Thrycha', 'Marie-Jeanne', 'Trou Aux Biches', 'Male', 'Receptionist and administrator');

Insert into Customer (CustomerId,EmployeeId,CustomerFname,CustomerLname,gender,CustomerAddress,MedicalStatement,DiveInsuranceNum,DiverLevel,EmailAddress,PhoneNum) values (1, 0101, 'Alex', 'Jones', 'Male', 'Grand Baie', 'Healthy', 123456, 'Advanced', 'alexjones@email.com', 57893467);
Insert into Customer (CustomerId,EmployeeId,CustomerFname,CustomerLname,gender,CustomerAddress,MedicalStatement,DiveInsuranceNum,DiverLevel,EmailAddress,PhoneNum) values (2, 0202, 'John', 'Wick', 'Male', 'Grand Gaube', 'Healthy', 987654, 'Beginner', 'johnsmith@email.com',58856784);
Insert into Customer (CustomerId,EmployeeId,CustomerFname,CustomerLname,gender,CustomerAddress,MedicalStatement,DiveInsuranceNum,DiverLevel,EmailAddress,PhoneNum) values (3, 0303, 'Carly', 'Smith', 'Female', 'Trou aux Biches', 'Healthy', 567890, 'Advanced', 'carlasmith@email.com', 57893467);

Insert into Inventory (ItemId,ItemName,size,NumInStock, Price) values ('SUI456', 'Wetsuits' , 'Large', 90,500);
Insert into Inventory (ItemId,ItemName,size,NumInStock, Price) values ('TAN123', 'Tanks' ,'Small', 45,900);
Insert into Inventory (ItemId,ItemName,size,NumInStock, Price) values ('MAS786', 'Diving Masks' , 'Large', 30,150);
Insert into Inventory (ItemId,ItemName,size,NumInStock, Price) values ('SUI897', 'Wetsuits' , 'Small', 75,450);
Insert into Inventory (ItemId,ItemName,NumInStock, Price) values ('COB348', 'Course Books', 90, 1000);
Insert into Inventory (ItemId,ItemName,size,NumInStock, Price) values ('MAS654', 'Diving Masks' , 'Medium', 67,100);
Insert into Inventory (ItemId,ItemName,size,NumInStock, Price) values ('SUI690', 'Wetsuits' , 'Medium', 65, 475);
Insert into Inventory (ItemId,ItemName,Size,NumInStock, Price) values ('HOOD456', 'Hoodies' , 'Large', 45, 600);
Insert into Inventory (ItemId,ItemName,NumInStock, Price) values ('FIN789', 'Fins' , 35, 1000);
Insert into Inventory (ItemId,ItemName,NumInStock, Price) values ('SNO675', 'Snorkelling Sets' , 15, 900);
Insert into Inventory (ItemId,ItemName,NumInStock, Price) values ('SHI432', 'T-Shirts' , 20, 350);
Insert into Inventory (ItemId,ItemName,NumInStock, Price) values ('CAP623', 'Caps' , 30, 150);
Insert into Inventory (ItemId,ItemName,NumInStock, Price) values ('DIV123', 'Diving Masks' , 65, 475);

Insert into Booking (BookingId,CustomerId,EmployeeId, DiveName,CourseName) values (100, 1, 0101, 'Discover Scuba Diving','Open Water Course');
Insert into Booking (BookingId,CustomerId,EmployeeId, DiveName) values (101, 2, 0202, 'Night Dive');
Insert into Booking (BookingId,CustomerId,EmployeeId, CourseName) values (102, 3, 0303, 'Advanced Open Water Course');

Insert into payment (AccountNumber, BookingId,EmployeeId,CustomerId, NumberOfDives,DivePrice,CoursePrice,ProductPrice,PaymentMethod,TotalAmount) values (000123456789,100,0101,1,3,2500,17000,100, 'Cash',24600);
Insert into payment (AccountNumber,BookingId,EmployeeId,CustomerId,NumberOfDives,DivePrice,CoursePrice,ProductPrice,PaymentMethod,TotalAmount) values (000765123456,101,0202,2,1,2000,15000,300, 'Credit Card',17300);
Insert into payment (AccountNumber,BookingId,EmployeeId,CustomerId,NumberOfDives,DivePrice,CoursePrice,ProductPrice,PaymentMethod,TotalAmount) values (000346794567,102,0303,3,2,5000,45000,500, 'MCB Juice',55500);

Insert into users (Username,Passwords,UserType) values ('DiveSpirit', 'Pass1234', 'Employee');
Insert into users (Username,Passwords,UserType) values ('KFatima', 'Emojipop', 'Admin');

select * from Customer
 select * from Employee
 select * from Inventory
 select * from booking
 select * from payment
 select * from users