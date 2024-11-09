drop database if exists ComB_Grupo2_ClubDeportivo;
create database ComB_Grupo2_ClubDeportivo;
use ComB_Grupo2_ClubDeportivo;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(99,'Administrador'),
(100,'Recepcionista'),
(101,'Profesor');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);



insert into usuario(NombreUsu,PassUsu,RolUsu) values
('Usuario_a','a',99),
('Usuario_b','b',100), 
('Usuario_c','c',101);

create table socios(
IdSocio int unsigned auto_increment,
Nombre varchar(30),
Apellido varchar(40),
DNI int unsigned unique, 
Activo boolean default true,
FechaIngreso DateTime default now(),
constraint pk_socios primary key(IdSocio)
);

create table fichaMedica(
DNI int unsigned,
PuedeRealizarActividadFisica bool,
ConsumeMedicamentos bool,
enfPreex varchar (40),
Observaciones varchar (40),
PRIMARY KEY (DNI),
FOREIGN KEY (DNI) REFERENCES socios(DNI)
);
