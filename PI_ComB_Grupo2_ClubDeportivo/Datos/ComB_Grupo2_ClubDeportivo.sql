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

create table profesores(
Id int unsigned auto_increment,
Nombre varchar(30),
Apellido varchar(40),
DNI int unsigned unique,
constraint primary key(Id)
);

insert into profesores(Nombre,Apellido,DNI) values
('Profesor','UNO',51111111),
('Profesor','DOS',52222222),
('Profesor','TRES',53333333),
('Profesor','CUATRO',54444444),
('Profesor','CINCO',56555555);

create table actividades(
Id  int unsigned auto_increment,
Nombre varchar(30),
IdProfesor  int unsigned,
IdSocio int unsigned,
primary key (Id),
foreign key (IdSocio) references socios(IdSocio),
foreign key (IdProfesor) references profesores(Id)
);

insert into actividades(Nombre,IDProfesor) values
("Actividad1",1),
("Actividad2",2),
("Actividad3",3),
("Actividad4",4),
("Actividad5",5);

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

create table formaDePago(
IdSocio int unsigned unique,
Cobro varchar(40),
primary key (IdSocio),
foreign key (IdSocio) references socios(IdSocio)
);

create table cuota(
Id int unsigned auto_increment,
IdSocio int unsigned,
Vencida boolean default false,
Pagada boolean default false,
Monto double,
Vencimiento datetime,
FechaPago datetime null,
primary key(Id),
foreign key(IdSocio) references socios(IdSocio)
);

#Cuotas a vencer
INSERT INTO cuota (IdSocio, Pagada, Monto, Vencimiento, FechaPago) VALUES
(1, true, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 09:15:00'),
(2, false, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(3, true, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 12:05:30'),
(4, false, 10000, CURRENT_DATE +  INTERVAL '23:59:59' HOUR_SECOND, null),
(5, false, 400, CURRENT_DATE +  INTERVAL '23:59:59' HOUR_SECOND, null),
(6, true, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 16:45:15'),
(7, false, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(8, true, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 10:30:45'),
(9, true, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 08:20:00'),
(10, false, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(11, true, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 14:55:25'),
(12, false, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(13, true, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 11:12:40'),
(14, true, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 15:40:30'),
(15, false, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(16, true, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 09:55:10'),
(17, false, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(18, true, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 13:10:05'),
(19, false, 400, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, null),
(20, true, 10000, CURRENT_DATE + INTERVAL '23:59:59' HOUR_SECOND, '2024-11-13 16:25:00');

#Cuotas sin pagar
INSERT INTO cuota (IdSocio, Pagada, Monto, Vencimiento, FechaPago) VALUES
(1, false, 400, '2024-11-05 23:59:59', null),
(2, false, 10000, '2024-11-10 23:59:59', null),
(3, false, 400, '2024-11-15 23:59:59', null),
(4, false, 10000, '2024-11-20 23:59:59', null),
(5, false, 400, '2024-11-25 23:59:59', null),
(6, false, 10000, '2024-11-07 23:59:59', null),
(7, false, 400, '2024-11-12 23:59:59', null),
(8, false, 10000, '2024-11-18 23:59:59', null),
(1, false, 400, '2024-11-22 23:59:59', null),
(2, false, 10000, '2024-11-29 23:59:59', null);
#Cuotas Historicas
INSERT INTO cuota (IdSocio, Pagada, Monto, Vencimiento, FechaPago) VALUES
(2, true, 10000, '2024-01-15 23:59:59', '2024-01-14 16:35:00'),
(3, true, 400, '2024-02-10 23:59:59', '2024-02-09 09:12:45'),
(4, true, 10000, '2024-03-25 23:59:59', '2024-03-23 10:47:20'),
(5, true, 400, '2024-04-12 23:59:59', '2024-04-11 08:30:15'),
(6, true, 10000, '2024-05-09 23:59:59', '2024-05-08 11:50:30'),
(7, true, 400, '2024-06-20 23:59:59', '2024-06-18 14:05:42'),
(8, true, 10000, '2024-07-14 23:59:59', '2024-07-13 16:15:59'),
(1, true, 400, '2024-08-30 23:59:59', '2024-08-29 10:20:33'),
(2, true, 10000, '2024-09-18 23:59:59', '2024-09-17 09:45:12'),
(3, true, 400, '2024-10-02 23:59:59', '2024-10-01 08:30:05'),
(4, true, 10000, '2024-11-22 23:59:59', '2024-11-21 15:23:40'),
(5, true, 400, '2024-12-07 23:59:59', '2024-12-06 10:56:12'),
(6, true, 10000, '2024-01-28 23:59:59', '2024-01-27 11:11:09'),
(7, true, 400, '2024-02-19 23:59:59', '2024-02-18 14:50:28'),
(8, true, 10000, '2024-03-06 23:59:59', '2024-03-05 08:43:00'),
(1, true, 400, '2024-04-23 23:59:59', '2024-04-22 15:35:45'),
(2, true, 10000, '2024-05-13 23:59:59', '2024-05-12 10:18:12'),
(3, true, 400, '2024-06-25 23:59:59', '2024-06-24 11:27:50'),
(4, true, 10000, '2024-07-17 23:59:59', '2024-07-16 09:19:20'),
(5, true, 400, '2024-08-04 23:59:59', '2024-08-03 13:14:10'),
(6, true, 10000, '2024-09-12 23:59:59', '2024-09-11 16:45:30'),
(7, true, 400, '2024-10-28 23:59:59', '2024-10-27 14:08:05'),
(8, true, 10000, '2024-11-03 23:59:59', '2024-11-02 12:33:50'),
(1, true, 400, '2024-12-19 23:59:59', '2024-12-18 09:27:55'),
(2, true, 10000, '2024-01-04 23:59:59', '2024-01-03 11:10:20'),
(3, true, 400, '2024-02-15 23:59:59', '2024-02-14 08:15:30'),
(4, true, 10000, '2024-03-21 23:59:59', '2024-03-20 10:55:15'),
(5, true, 400, '2024-04-09 23:59:59', '2024-04-08 13:42:00'),
(6, true, 10000, '2024-05-05 23:59:59', '2024-05-04 14:22:35'),
(7, true, 400, '2024-06-30 23:59:59', '2024-06-29 09:59:00'),
(8, true, 10000, '2024-07-25 23:59:59', '2024-07-24 15:34:55'),
(1, true, 400, '2024-08-16 23:59:59', '2024-08-15 12:50:45'),
(2, true, 10000, '2024-09-01 23:59:59', '2024-08-31 08:05:20');

create table fichaMedica(
DNI int unsigned,
PuedeRealizarActividadFisica bool,
ConsumeMedicamentos bool,
enfPreex varchar (40),
Observaciones varchar (40),
PRIMARY KEY (DNI),
FOREIGN KEY (DNI) REFERENCES socios(DNI)
);

call IntroducirSocio('Nombre_1', 'Apellido_1', 11111111, 'Mensual',@out);
call IntroducirFicha(11111111, true, false, '', '',@out);
call IntroducirSocio('Nombre_2', 'Apellido_2', 22222222, 'Diario',@out);
call IntroducirFicha(22222222, true, false, '', '',@out);
call IntroducirSocio('Nombre_3', 'Apellido_3', 33333333, 'Mensual',@out);
call IntroducirFicha(33333333, true, false, '', '',@out);
call IntroducirSocio('Nombre_4', 'Apellido_4', 44444444, 'Diario',@out);
call IntroducirFicha(44444444, true, false, '', '',@out);
call IntroducirSocio('Nombre_5', 'Apellido_5', 55555555, 'Mensual',@out);
call IntroducirFicha(55555555, true, false, '', '',@out);

## DATOS GENERADOS ALEATORIAMENTE CON CHATGPT
INSERT INTO socios (Nombre, Apellido, DNI, FechaIngreso) VALUES
('Carlos', 'Gonzalez', 12345678, '2023-03-11 14:22:30'),
('Lucia', 'Martinez', 87654321, '2023-07-19 09:13:45'),
('Mario', 'Lopez', 23456789, '2023-11-27 18:31:12'),
('Ana', 'Perez', 34567890, '2023-01-14 23:55:00'),
('Jorge', 'Diaz', 45678901, '2023-06-25 16:42:37'),
('Clara', 'Suarez', 56789012, '2024-02-18 08:23:14'),
('Mateo', 'Rodriguez', 67890123, '2024-04-12 11:47:28'),
('Elena', 'Gomez', 78901234, '2024-09-30 21:39:05'),
('Pablo', 'Garcia', 89012345, '2023-05-05 13:18:20'),
('Valeria', 'Mendez', 90123456, '2023-12-02 06:54:11'),
('Sofia', 'Ruiz', 21345678, '2024-03-15 15:44:56'),
('Andres', 'Vega', 32456789, '2023-08-07 03:27:34'),
('Natalia', 'Jimenez', 43567890, '2024-10-02 12:12:12'),
('Luis', 'Torres', 54678901, '2023-02-21 20:50:47'),
('Isabella', 'Romero', 65789012, '2024-06-29 19:17:02'),
('Benjamin', 'Castro', 76890123, '2023-04-10 12:05:09'),
('Camila', 'Silva', 87901234, '2024-07-08 04:38:13'),
('Gabriel', 'Ortiz', 98012345, '2023-09-03 11:33:49'),
('Florencia', 'Navarro', 19234567, '2024-01-23 22:12:00'),
('Enrique', 'Herrera', 20345678, '2024-05-14 10:21:33'),
('Mia', 'Cano', 31456789, '2023-10-20 08:45:25'),
('Alejandro', 'Luna', 42567890, '2023-11-29 07:59:18'),
('Victoria', 'Paredes', 53678901, '2023-12-15 02:16:43'),
('Lucas', 'Morales', 64789012, '2024-03-03 14:30:27'),
('Martina', 'Reyes', 75890123, '2023-01-12 05:47:52'),
('Santiago', 'Aguilar', 86901234, '2024-04-17 17:58:36'),
('Juliana', 'Muñoz', 97012345, '2024-08-21 09:14:00'),
('Francisco', 'Vargas', 18123456, '2023-05-30 12:32:11'),
('Renata', 'Blanco', 29234567, '2023-07-16 23:50:40'),
('Sebastian', 'Rios', 30345678, '2024-10-02 12:12:12'),
('Eva', 'Soto', 41456789, '2024-02-28 07:25:08'),
('Hugo', 'Farias', 52567890, '2023-03-22 13:56:19'),
('Noah', 'Campos', 63678901, '2023-09-28 19:42:55'),
('Daniela', 'Salazar', 74789012, '2024-06-07 03:11:47'),
('Tomas', 'Mora', 85890123, '2024-01-09 15:18:33'),
('Samantha', 'Peña', 96901234, '2023-08-14 10:04:21'),
('Bruno', 'Maldonado', 17234567, '2023-11-11 22:39:06'),
('Lola', 'Fuentes', 28345678, '2024-07-13 04:51:14'),
('Ignacio', 'Carrillo', 39456789, '2023-10-08 01:17:00'),
('Paula', 'Santana', 40567890, '2024-09-05 12:48:52'),
('Rodrigo', 'Acosta', 51678901, '2024-05-26 20:36:18'),
('Melina', 'Benitez', 62789012, '2023-06-18 03:28:49'),
('Gonzalo', 'Leiva', 73890123, '2024-08-02 09:55:30'),
('Catalina', 'Rivas', 84901234, '2024-03-21 18:14:09'),
('Emiliano', 'Mendoza', 95012345, '2023-07-04 14:39:57'),
('Salvador', 'Cabrera', 16123456, '2024-02-11 11:20:41'),
('Antonia', 'Bermudez', 27234567, '2023-05-13 22:02:24'),
('Rafael', 'Peralta', 38345678, '2024-04-04 06:30:17'),
('Emilia', 'Esquivel', 49456789, '2023-12-25 15:47:35'),
('Adrian', 'Bustos', 50567890, '2023-08-23 08:11:53');

