CREATE DATABASE COMPUTADORABD
GO

USE COMPUTADORABD
GO

CREATE TABLE COMPUTADORA (
IDCOMPUTADORA INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
DESCRIPCION NVARCHAR (50) NOT NULL,
PRECIO MONEY NOT NULL,
FECHADEFABRICACION DATETIME NOT NULL,
PRIMARY KEY (IDCOMPUTADORA))
GO

insert into computadora values('Dell G5' ,'Color Negro',7000,'2022-08-20 12:50:00');
insert into computadora values('Asus' ,'Pantalla de 12 pulgadas' ,2000,'2022-10-10 12:50:00');
insert into computadora values('Samsung' ,'Color Azul' ,3000,'2023-01-10 12:50:00');
insert into computadora values('Alienware' ,'Pantalla de 5 pulgadas' ,5000,'2023-02-10 12:50:00');
insert into computadora values('Thor' ,'Marca de Rayo' ,7000,'2023-08-10 12:50:00');