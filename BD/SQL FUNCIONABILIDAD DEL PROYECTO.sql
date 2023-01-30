Create Database EJERCICIO1;
GO
Use EJERCICIO1; 

Create table ROL(
NOMBRE_USUARIO varchar (50) not null Primary Key,
CONTRASEÑA varchar (50),
ROL varchar (50),
); 
delete from ROL where NOMBRE_USUARIO = 'cronosjp' ;
GO 
Insert into ROL values ('ekhar','12345','Administrador');
Insert into ROL values ('cronosjp','0011','Secretariado');
Insert into ROL values ('luna','1411','Usuario');
Insert into ROL values ('juarezperez','0014','Secretariado');
GO

Select * from ROL;

Create table INGRESO(
ID int not null Primary Key, 
Nombre varchar(50),
Apellido varchar (50),
Correo varchar (50), 
Edad int not null,
usuario varchar (50),
contraseña varchar (50), 
Rol varchar (50), 
);
GO
Select * from INGRESO;
