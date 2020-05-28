create procedure InsertCustomer
@CustomerId int,
@EmployeeId int,
@CustomerFname varchar(max),
@CustomerLname varchar(max),
@gender varchar(max),
@CustomerAddress varchar(max),
@MedicalStatement varchar(max),
@DiveInsuranceNum int,
@DiverLevel varchar(max),
@EmailAddress varchar(max),
@PhoneNum int

as begin

insert into Customer(CustomerId, EmployeeId, CustomerFname, CustomerLname,gender, CustomerAddress, MedicalStatement, DiveInsuranceNum, DiverLevel, EmailAddress, PhoneNum) values
(@CustomerId, @EmployeeId, @CustomerFname, @CustomerLname,@gender,@CustomerAddress, @MedicalStatement, @DiveInsuranceNum, @DiverLevel, @EmailAddress, @PhoneNum)

end