CREATE DATABASE BDCINE
GO
USE BDCINE
GO

CREATE TABLE Pelicula
(
idPelicula int primary key identity,
Titulo varchar(40),
TituloOriginal varchar(50),
Duracion varchar(8),
Pais varchar(30),
Sinopsis varchar(150),
Censura varchar(20),
ListaActores varchar(200),
Genero varchar(50),
Estado varchar(20),
Idioma varchar(20),
Subtitulos varchar(2),
Imagen image
)
GO


CREATE TABLE CINE
(
idCine int primary key identity,
Nombre varchar(50),
Provincia varchar(50),
Direccion varchar(50),
Aforo int,
nroSalas int ,
);

Create Table Sala
(
idSala int primary key identity,
aforo int,
nroPiso int,
idCine int
)

Alter Table Sala
Add Constraint FK_Sala_Cine Foreign Key(idCine) References CINE(idCine)
go

Create Table Butaca
(
idButaca int primary key identity,
idSala int,
nroButaca int,
estado bit,
)
go
Alter Table Butaca
Add Constraint FK_Butaca_Sala Foreign Key(idSala) References Sala(idSala)
go


Create Table Usuario 
(
IdUsuario int primary key identity,
Nombre varchar(50),
Apellido varchar(50),
Direccion varchar(60),
Telefono varchar(12),
Dni char(8),
userName varchar(20),
Clave varchar(15),
TipoUsuario varchar(25)
)

select * from Usuario
go

Create Table Cartelera
(
idCartelera int primary key identity,
horaIncio varchar(5),
horaFin varchar(5),
idPelicula int , 
fecha date,
precio decimal(8,2)
)
go

Alter Table Cartelera
Add Constraint FK_Caterlera_Pelicula Foreign Key(idPelicula) References Pelicula(idPelicula)
go


Create table Reserva 
(
idReserva int primary key identity,
idUsuario int ,
montoTotal decimal(8,2),
idCartelera int
)
go
Alter Table Reserva
Add Constraint FK_Reserva_idCarteler Foreign Key(idCartelera) References Cartelera(idCartelera)
go

Alter Table Reserva
Add Constraint FK_Reserva_Usuario Foreign Key(idUsuario) References Usuario(idUsuario)
go



Create Table DetalleReserva
(
idDetalleReserva int primary key,
idReserva int,
idButaca int,
precio decimal(8,2)
)
go

Alter Table DetalleReserva
ADD Constraint FK_Detale_Reserva Foreign Key(idReserva) References Reserva(idReserva)
go

Alter Table DetalleReserva
Add constraint FK_Detalle_Butaca Foreign Key(idButaca) References Butaca(idButaca)
go

Alter Table Pelicula
Alter column Imagen image
go

SELECT * FROM USUARIO;
select * from CINE;
SELECT * FROM SALA;
SELECT * FROM Pelicula;


insert into Pelicula values('Dead Pool',
'JEJEJE',
'120 minutos',
'Peru',
'JAJAJAKEKEKKEKAMSDASd',
'mayores de 18',
'asdasdas,asdasd,asdasd,asdasd,asdasd',
'Accion',
'en Cartelera',
'ingles','si',NULL)

insert into Pelicula values
(Titulo='Dead Pool',
TituloOriginal varchar(50),
Duracion varchar(8),
Pais varchar(30),
Sinopsis varchar(150),
Censura varchar(20),
ListaActores varchar(200),
Genero varchar(50),
Estado varchar(20),
Idioma varchar(20),
Subtitulos varchar(2),
Imagen image
)