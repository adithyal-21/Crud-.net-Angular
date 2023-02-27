Create database Crud
use crud

create table users(
ID int primary key IDENTITY(1000,1),
Name varchar(30) not null,
Email varchar(30) not null unique,
Phone numeric(10)  not null unique,
Age int check (Age > 18) not null,
Gender char not null check (Gender in('M','F'))
)

